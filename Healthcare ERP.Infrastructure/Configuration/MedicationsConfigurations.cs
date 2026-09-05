using Healthcare_ERP.Application.SeedingDb;
using Healthcare_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Healthcare_ERP.Infrastructure.Configuration;

public class MedicationsConfigurations : IEntityTypeConfiguration<Medication>
{
    public void Configure(EntityTypeBuilder<Medication> builder)
    {
        builder.Property(d => d.Name).IsRequired().HasMaxLength(100);
        builder.ToTable("Medications");
        // builder.Property(d=>d.Price).IsRequired();
        builder.HasIndex(d=>d.Name).IsUnique();
        builder.HasData(MedicationSeed.Medications);
    }
}


