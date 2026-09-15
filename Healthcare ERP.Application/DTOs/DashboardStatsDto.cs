using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare_ERP.Application.DTOs;

public class DashboardStatsDto
{
    public decimal TodaysRevenue { get; set; }
    public int TodaysAppointments { get; set; }
    public int TotalPatients { get; set; }
    public int TotalDoctors { get; set; }
    public int CompletedAppointments { get; set; }
    public int ScheduledAppointments { get; set; }
    public int CancelledAppointments { get; set; }
    public List<MedicationStatsDto> Top5Medications { get; set; }
}
