using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Healthcare_ERP.Domain.Enums;

namespace Healthcare_ERP.Domain.Entities;

public class Invoice:BaseEntity
{
    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }
    public decimal TotalAmount { get; set; }
    public PaymentStatus Status { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime PaymentDate { get; set; }
}
