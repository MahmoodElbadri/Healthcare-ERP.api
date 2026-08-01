// 1. الدواء الثابت في السيستم (قاموس الأدوية)
namespace Healthcare_ERP.Domain.Entities;

public class Medication : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Notes { get; set; }
}
