using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Interfaces;
using AutoMapper;
using Healthcare_ERP.Domain.Enums;
using Healthcare_ERP.Domain.Exceptions;

namespace Healthcare_ERP.Application.Services;

public class InvoiceService:IInvoiceService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public InvoiceService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<InvoiceDto>> GetAllInvoicesAsync()
    {
        var invoices =  _unitOfWork.Invoices.GetAll();
        return _mapper.Map<List<InvoiceDto>>(invoices);
    }

    public async Task<bool> PayInvoiceAsync(int invoiceId)
    {
        var invoice = await _unitOfWork.Invoices.Get(invoiceId);
        if (invoice==null) throw new NotFoundException("Invoice not found", invoiceId.ToString());
        if(invoice.Status == PaymentStatus.Paid) throw new BadRequestException("Invoice is already paid");
        invoice.Status = PaymentStatus.Paid;
        invoice.PaymentDate = DateTime.Now;
        await _unitOfWork.Invoices.Update(invoice);
        await _unitOfWork.CompleteAsync();
        return
            true;
    }
}