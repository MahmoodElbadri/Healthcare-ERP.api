
using Healthcare_ERP.Domain.Interfaces;
using Healthcare_ERP.Infrastructure.Data;
using Healthcare_ERP.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Healthcare_ERP.Infrastructure.Extensions;

public static class InfrastructureCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HealthDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
