using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Healthcare_ERP.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvoicesController : ControllerBase
{
    private readonly IInvoiceService _invoiceService;

    public InvoicesController(IInvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }

    [HttpGet("get-all-invoices")]
    public async Task<IActionResult> GetAllInvoices()
    {
        var invoices = await _invoiceService.GetAllInvoicesAsync();
        var successResponse = ApiResponse<List<InvoiceDto>>.Success(invoices);
        return Ok(successResponse);
    }

    [HttpPost("pay/{invoiceId}")]
    public async Task<IActionResult> PayInvoiceAsync(int invoiceId)
    {
        var result = await _invoiceService.PayInvoiceAsync(invoiceId);
        var response = ApiResponse<bool>.Success(result);
        return Ok(response);
    }
}