using Healthcare_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Healthcare_ERP.Infrastructure.Configuration;

public class DoctorConfigurations : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.Property(d => d.Name).IsRequired().HasMaxLength(100);
        builder.ToTable("Doctors");
        builder.Property(tmp => tmp.PhoneNumber).IsRequired().HasMaxLength(20);
        builder.HasIndex(d => d.PhoneNumber).IsUnique();
        builder.Property(tmp => tmp.Specialty).IsRequired().HasMaxLength(50);
        //builder.HasIndex(d=>d.Specialty).IsUnique();
        builder.HasMany(tmp => tmp.Appointments).WithOne(tmp => tmp.Doctor).OnDelete(DeleteBehavior.Restrict);

    }
}


