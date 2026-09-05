using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Healthcare_ERP.Application.DTOs;

namespace Healthcare_ERP.Application.Interfaces;

public interface IMedicationService
{
    Task<IEnumerable<MedicationDto>> GetAllMedications();
}
