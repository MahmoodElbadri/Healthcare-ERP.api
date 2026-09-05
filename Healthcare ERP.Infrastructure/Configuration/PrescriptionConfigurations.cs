using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthcare_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Healthcare_ERP.Infrastructure.Configuration;

public class PrescriptionConfigurations : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder.ToTable("Prescriptions");
        builder.HasKey(p => p.Id);
        // builder.HasOne(p=>p.Diagnosis)
        // .WithOne(d=>d.Prescription)
        // .HasForeignKey<Prescription>(p=>p.DiagnosisId)
        // .OnDelete(DeleteBehavior.Cascade);
    }
}
