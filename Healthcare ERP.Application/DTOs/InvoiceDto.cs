using Healthcare_ERP.Domain.Enums;

namespace Healthcare_ERP.Application.DTOs;

public class InvoiceDto
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime PaymentDate { get; set; }
}