using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Interfaces;

namespace Healthcare_ERP.Application.Services;

public class SpecialityService : ISpecialityService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public SpecialityService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<IEnumerable<SpecialityDto>> GetAllSpecialities()
    {
        var specialities = await _unitOfWork.Specialities.GetAll();
        return _mapper.Map<IEnumerable<SpecialityDto>>(specialities);
    }
}