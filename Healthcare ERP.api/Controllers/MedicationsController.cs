using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Healthcare_ERP.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicationsController : ControllerBase
    {
        private readonly IMedicationService _medicationService;
        private readonly ILogger<MedicationsController> _logger;
        public MedicationsController(IMedicationService medicationService, ILogger<MedicationsController> logger)
        {
            _medicationService = medicationService;
            _logger = logger;
        }

        [HttpGet("get-all-medications")]
        public async Task<IActionResult> GetAllMedications()
        {
            var medications = await _medicationService.GetAllMedications();
            var successResponse = ApiResponse<IEnumerable<MedicationDto>>.Success(medications);
            return Ok(successResponse);
        }
    }
}