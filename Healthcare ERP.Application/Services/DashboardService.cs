using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Enums;
using Healthcare_ERP.Domain.Interfaces;


namespace Healthcare_ERP.Application.Services;


public class DashboardService : IDashboardService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DashboardService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<DashboardStatsDto> GetDashboardStatsAsync()
    {
        var todayDateTime = DateTime.Today;
        var tomorrowDateTime = todayDateTime.AddDays(1);

        var todayDateOnly = DateOnly.FromDateTime(DateTime.Today);

        var todaysRevenue = await _unitOfWork.Invoices
            .SumAsync(i => i.IssueDate >= todayDateTime &&
                       i.IssueDate < tomorrowDateTime &&
                       i.Status == PaymentStatus.Paid,i=>i.TotalAmount);

        var todaysAppointments = await _unitOfWork.Appointments
            .CountAsync(a => a.AppointmentDate == todayDateOnly);

        var totalPatients = await _unitOfWork.Patients.CountAsync(p=>true);
        var totalDoctors = await _unitOfWork.Doctors.CountAsync(d=>true);

        var completedAppointments = await _unitOfWork.Appointments.CountAsync(a => a.Status == AppointmentStatus.Completed);
        var cancelledAppointments = await _unitOfWork.Appointments.CountAsync(a => a.Status == AppointmentStatus.Cancelled);
        var scheduledAppointments = await _unitOfWork.Appointments.CountAsync(a => a.Status == AppointmentStatus.Scheduled);


        var todaysPrescriptions = _unitOfWork.Prescriptions.FindWithIncludes(
            p => p.CreatedAt >= todayDateTime &&
                 p.CreatedAt < tomorrowDateTime,
            p => p.Items
        ).ToList();

        var allMedications = _unitOfWork.Medications.GetAll().ToList();

        var top5Medications = todaysPrescriptions
            .SelectMany(p => p.Items)
            .GroupBy(pd => pd.MedicationId)
            .OrderByDescending(g => g.Count())
            .Take(5)
            .Select(g => new MedicationStatsDto
            {
                MedicationName = allMedications.FirstOrDefault(m => m.Id == g.Key)?.Name ?? "Unknown",
                Count = g.Count()
            })
            .ToList();
      
        return new DashboardStatsDto
        {
            TodaysRevenue = todaysRevenue,
            TodaysAppointments = todaysAppointments,
            TotalPatients = totalPatients,
            TotalDoctors = totalDoctors,
            CompletedAppointments = completedAppointments,
            CancelledAppointments = cancelledAppointments,
            ScheduledAppointments = scheduledAppointments,
            Top5Medications = top5Medications
        };
    }
}
