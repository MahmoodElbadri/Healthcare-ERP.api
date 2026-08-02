using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Healthcare_ERP.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    private readonly IPatientService _patientService;
    public PatientsController(IPatientService patientService)
    {
        _patientService = patientService;
    }
    // GET
    [HttpGet("GetAllPatients")]
    public async Task<IActionResult> GetAllPatients()
    {
        var patients = await _patientService.GetAllPatients();
        return Ok(patients);
    }

    [HttpPost("AddPatient")]
    public async Task<IActionResult> AddPatient(AddPatientDto patientDto)
    {
        var addedPatientDto = await _patientService.AddPatient(patientDto);
        return Ok(addedPatientDto);
    }

}
