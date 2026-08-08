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
public class DoctorsController : ControllerBase
{
    private readonly IDoctorService _doctorService;
    public DoctorsController(IDoctorService doctorService)
    {
        _doctorService = doctorService;
    }
    // GET
    [HttpGet("GetAllDoctors")]
    public async Task<IActionResult> GetAllDoctors()
    {
        var doctors = await _doctorService.GetAllDoctors();
        var successResponse = ApiResponse<IEnumerable<DoctorDto>>.Success(doctors);
        return Ok(successResponse);
    }

    [HttpPost("AddDoctor")]
    public async Task<IActionResult> AddDoctor(AddDoctorDto doctorDto)
    {
        var addedDoctorDto = await _doctorService.AddDoctor(doctorDto);
        var successResponse = ApiResponse<DoctorDto>.Success(addedDoctorDto);
        return Ok(successResponse);
    }

    [HttpGet("GetDoctorById/{doctorId}")]
    public async Task<IActionResult> GetDoctorById([FromRoute] int doctorId)
    {
        var doctorDto = await _doctorService.GetDoctorById(doctorId);
        var successResponse = ApiResponse<DoctorDto>.Success(doctorDto);
        return Ok(successResponse);
    }

    [HttpDelete("DeleteDoctor/{doctorId}")]
    public async Task<IActionResult> DeleteDoctor([FromRoute] int doctorId)
    {
        await _doctorService.DeleteDoctor(doctorId);
        var successResponse = ApiResponse<DoctorDto>.Success(null,"Doctor deleted successfully");
        return Ok(successResponse);
    }

    [HttpPut("UpdateDoctor/{doctorId}")]
    public async Task<IActionResult> UpdateDoctor([FromRoute] int doctorId, UpdateDoctorDto doctorDto)
    {
        await _doctorService.UpdateDoctor(doctorDto);
        var successResponse = ApiResponse<DoctorDto>.Success(null,"Doctor updated successfully");
        return Ok(successResponse);
    }



}