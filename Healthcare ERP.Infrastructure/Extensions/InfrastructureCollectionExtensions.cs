
using Healthcare_ERP.Infrastructure.Data;
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
        return services;
    }
}
