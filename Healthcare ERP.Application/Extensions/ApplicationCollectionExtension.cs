using Microsoft.Extensions.DependencyInjection;

namespace Healthcare_ERP.Application.Extensions;

public static class ApplicationCollectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}
