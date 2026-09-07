using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Domain.Entities;

namespace Healthcare_ERP.Application.Mappings;

public class InvoiceProfile:Profile
{
    public InvoiceProfile()
    {
        CreateMap<Invoice, InvoiceDto>();
    }
}