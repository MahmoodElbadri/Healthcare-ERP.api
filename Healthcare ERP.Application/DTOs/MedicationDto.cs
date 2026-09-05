using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare_ERP.Application.DTOs;
public class MedicationDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Notes { get; set; }
}