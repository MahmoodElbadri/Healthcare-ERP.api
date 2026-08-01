using Healthcare_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Healthcare_ERP.Infrastructure.Configuration;

public class PatientConfigurations : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.Property(d => d.Name).IsRequired().HasMaxLength(100);
        builder.ToTable("Patients");
        builder.Property(tmp=>tmp.PhoneNumber).IsRequired().HasMaxLength(20);
        builder.HasIndex(d=>d.PhoneNumber).IsUnique();
        builder.HasMany(tmp=>tmp.Appointments).WithOne(tmp=>tmp.Patient).OnDelete(DeleteBehavior.Restrict);
      

    }
}


