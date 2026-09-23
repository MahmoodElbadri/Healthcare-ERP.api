using Hangfire;
using Healthcare_ERP.api.Middlewares;
using Healthcare_ERP.Application.Extensions;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Application.Seeders;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

builder.Host.UseSerilog();

try
{
    Log.Information("Starting up the service...");


    // Add services to the container.
    builder.Services.AddAuthentication();

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddInfrastructure(builder.Configuration);
    builder.Services.AddApplication();


    

    //adding cors
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowFrontend",
            builder =>
            {
                builder.WithOrigins("http://localhost:4200")
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
    });

    var app = builder.Build();

    app.UseMiddleware<ExceptionHandlingMiddleware>();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();
    app.UseCors("AllowFrontend");
    app.UseAuthentication();
    app.UseAuthorization();

    app.UseHangfireDashboard("/hangfire");


    app.MapControllers();

    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        var recurringJobManager = services.GetRequiredService<IRecurringJobManager>();
        recurringJobManager.AddOrUpdate<IAppointmentService>(
            "CancelNotCompletedAppointmentsBeforeToday",
            s => s.CancelNotCompletedAppointmentsBeforeToday(),
            Cron.Daily);

        try
        {
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var configuration = services.GetRequiredService<IConfiguration>();

            await RoleSeeder.SeedRolesAsync(roleManager);
            await UserSeeder.SeedAdminUserAsync(userManager, roleManager, configuration);
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "❌ Error occurred while seeding database");
        }
    }

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application start-up failed");
}
finally
{
    Log.CloseAndFlush();
}
