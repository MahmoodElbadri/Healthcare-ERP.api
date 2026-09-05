using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Healthcare_ERP.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExaminationsController : ControllerBase
{
    private readonly IExaminationService _examinationService;
    private readonly ILogger<ExaminationsController> _logger;
    public ExaminationsController(IExaminationService examinationService, ILogger<ExaminationsController> logger)
    {
        _examinationService = examinationService;
        _logger = logger;
    }

    [HttpPost("save-examination")]
    public async Task<IActionResult> SaveExamination([FromBody] SaveExaminationDto saveExaminationDto)
    {
        _logger.LogInformation("Saving examination for appointment {AppointmentId}", saveExaminationDto.DiagnosisDto.AppointmentId);
        await _examinationService.SaveExaminationAsync(saveExaminationDto.DiagnosisDto, saveExaminationDto.PrescriptionDto);
        _logger.LogInformation("Examination saved successfully for appointment {AppointmentId}", saveExaminationDto.DiagnosisDto.AppointmentId);

        var successResponse = ApiResponse<bool>.Success(true);
        return Ok(successResponse);
    }
}