using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Healthcare_ERP.api.Controllers
{
    [Route("api/[controller]")]
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
            var result = await _appointmentService.AddAppointment(dto);
            var successResponse = ApiResponse<AppointmentDto>.Success(result, "Appointment added successfully");
            return Ok(successResponse);
        }

        [HttpGet("Doctor/{doctorId}")]
        public async Task<IActionResult> GetDoctorAppointments([FromRoute] int doctorId)
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

        [HttpGet("GetAllAppointments")]
        public async Task<IActionResult> GetAllAppointments()
        {
            var appointments = await _appointmentService.GetAllAppointments();
            var successResponse = ApiResponse<IEnumerable<AppointmentDto>>.Success(appointments);
            return Ok(successResponse);
        }
        
    }
}