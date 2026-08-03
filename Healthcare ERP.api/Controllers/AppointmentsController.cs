using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        
    }
}