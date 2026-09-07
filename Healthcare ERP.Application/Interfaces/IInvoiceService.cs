using Healthcare_ERP.Application.DTOs;

namespace Healthcare_ERP.Application.Interfaces;

public interface IInvoiceService
{
    Task <List<InvoiceDto>> GetAllInvoicesAsync();
    Task <bool> PayInvoiceAsync(int invoiceId);
}