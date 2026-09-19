using Healthcare_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Healthcare_ERP.Infrastructure.Configuration;

public class InvoiceConfigurations : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable("Invoices");
        builder.HasKey(i => i.Id);
        builder.Property(i => i.TotalAmount).HasPrecision(18, 2);
    }
}