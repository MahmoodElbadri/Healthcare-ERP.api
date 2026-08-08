using Healthcare_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Healthcare_ERP.Infrastructure.Data;

public class HealthDbContext:DbContext
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Diagnosis> Diagnoses { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<PrescriptionItem> PrescriptionItems { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Speciality> Specialities { get; set; }
    public HealthDbContext(DbContextOptions<HealthDbContext> options) : base(options)
    {
        
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        configurationBuilder.Properties<Enum>()
            .HaveConversion<string>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }


}
