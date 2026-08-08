using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Healthcare_ERP.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly ILogger<AppointmentsController> _logger;
        private readonly IAppointmentService _appointmentService;

        public AppointmentsController(ILogger<AppointmentsController> logger , IAppointmentService appointmentService)
        {
            _logger = logger;
            _appointmentService = appointmentService;
        }

        [HttpPost("Add-Appointment")]
        public async Task<IActionResult> AddAppointment(AddAppointmentDto dto)
        {
            await _appointmentService.AddAppointment(dto);
            var successResponse = ApiResponse<bool>.Success(true, "Appointment added successfully");
            return Ok(successResponse);
        }

        [HttpGet("Doctor")]
        public async Task<IActionResult> GetDoctorAppointments([FromQuery] int doctorId)
        {
            var appointments = await _appointmentService.GetDoctorAppointments(doctorId);
            var successResponse = ApiResponse<IEnumerable<AppointmentDto>>.Success(appointments);
            return Ok(successResponse);
        }

        [HttpPatch("UpdateStatus")]
        public async Task<IActionResult> UpdateAppointmentStatus(UpdateAppointmentStatusDto dto)
        {
            await _appointmentService.UpdateAppointmentStatus(dto);
            var successResponse = ApiResponse<bool>.Success(true, "Appointment status updated successfully");
            return Ok(successResponse);
        }
        
    }
}