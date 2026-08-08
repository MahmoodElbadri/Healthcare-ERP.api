using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Application.Services;
using Healthcare_ERP.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Healthcare_ERP.Application.Extensions;

public static class ApplicationCollectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<IDoctorService,DoctorService>();
        services.AddScoped<IPatientService,PatientService>();
        services.AddScoped<ISpecialityService, SpecialityService>();
        services.AddScoped<IAppointmentService,AppointmentService>();
    }
}
