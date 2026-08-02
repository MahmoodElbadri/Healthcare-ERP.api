using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Interfaces;
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
        return Ok(doctors);
    }

    [HttpPost("AddDoctor")]
    public async Task<IActionResult> AddDoctor(AddDoctorDto doctorDto)
    {
        var addedDoctorDto = await _doctorService.AddDoctor(doctorDto);
        return Ok(addedDoctorDto);
    }

}