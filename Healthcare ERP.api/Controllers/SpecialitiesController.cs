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
    public class SpecialitiesController : ControllerBase
    {
        private readonly ISpecialityService _specialityService;

        public SpecialitiesController(ISpecialityService specialityService)
        {
            _specialityService = specialityService;
        }

        [HttpGet("GetAllSpecialities")]
        public async Task<IActionResult> GetAllSpecialities()
        {
            var specialities = await _specialityService.GetAllSpecialities();
            var successResponse = ApiResponse<IEnumerable<SpecialityDto>>.Success(specialities);
            return Ok(successResponse);
        }
    }
}