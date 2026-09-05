using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Healthcare_ERP.Domain.Entities;

namespace Healthcare_ERP.Application.SeedingDb;

public static class SpecialitySeed
{
    public static readonly List<Speciality> Specialities = new()
    {
        new Speciality { Id = 1, Name = "Cardiology" },
        new Speciality { Id = 2, Name = "Dermatology" },
        new Speciality { Id = 3, Name = "Neurology" },
        new Speciality { Id = 4, Name = "Pediatrics" },
        new Speciality { Id = 5, Name = "Orthopedics" },
        new Speciality { Id = 6, Name = "Ophthalmology" },
        new Speciality { Id = 7, Name = "Dentistry" },
        new Speciality { Id = 8, Name = "Gynecology and Obstetrics" },
        new Speciality { Id = 9, Name = "Urology" },
        new Speciality { Id = 10, Name = "Gastroenterology" },
        new Speciality { Id = 11, Name = "Pulmonology" },
        new Speciality { Id = 12, Name = "Psychiatry" },
        new Speciality { Id = 13, Name = "Endocrinology" },
        new Speciality { Id = 14, Name = "Nephrology" },
        new Speciality { Id = 15, Name = "Oncology" },
        new Speciality { Id = 16, Name = "Otolaryngology (ENT)" },
        new Speciality { Id = 17, Name = "General Surgery" },
        new Speciality { Id = 18, Name = "Internal Medicine" },
        new Speciality { Id = 19, Name = "Family Medicine" },
        new Speciality { Id = 20, Name = "Emergency Medicine" },
        new Speciality { Id = 21, Name = "Anesthesiology" },
        new Speciality { Id = 22, Name = "Rheumatology" },
        new Speciality { Id = 23, Name = "Hematology" },
        new Speciality { Id = 24, Name = "Infectious Diseases" },
        new Speciality { Id = 25, Name = "Allergy and Immunology" }
    };
}
