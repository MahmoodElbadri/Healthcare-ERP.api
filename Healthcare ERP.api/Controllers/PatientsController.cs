using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Interfaces;
using Healthcare_ERP.Domain.Wrappers;
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
    [ProducesResponseType(typeof(ApiResponse<IEnumerable<PatientDto>>), 200)]
    [ProducesResponseType(typeof(ApiResponse<IEnumerable<PatientDto>>), 500)]
    public async Task<IActionResult> GetAllPatients()
    {
        var patients = await _patientService.GetAllPatients();
        var successResponse = ApiResponse<IEnumerable<PatientDto>>.Success(patients);
        return Ok(successResponse);
    }

    [HttpPost("AddPatient")]
    public async Task<IActionResult> AddPatient(AddPatientDto patientDto)
    {
        var addedPatientDto = await _patientService.AddPatient(patientDto);
        var successResponse = ApiResponse<PatientDto>.Success(addedPatientDto);
        return Ok(successResponse);
    }

    [HttpGet("GetPatientById/{patientId}")]
    public async Task<IActionResult> GetPatientById([FromRoute] int patientId)
    {
        var patientDto = await _patientService.GetPatientById(patientId);
        var successResponse = ApiResponse<PatientDto>.Success(patientDto);
        return Ok(successResponse);
    }

    [HttpDelete("DeletePatient/{patientId}")]
    public async Task<IActionResult> DeletePatient([FromRoute] int patientId)
    {
        await _patientService.DeletePatient(patientId);
        var successResponse = ApiResponse<PatientDto>.Success(null,"Patient deleted successfully");
        return Ok(successResponse);
    }

    [HttpPut("UpdatePatient/{patientId}")]
    public async Task<IActionResult> UpdatePatient([FromRoute] int patientId,UpdatePatientDto patientDto)
    {
        await _patientService.UpdatePatient(patientDto);
        var successResponse = ApiResponse<PatientDto>.Success(null,"Patient updated successfully");
        return Ok(successResponse);
    }

}
