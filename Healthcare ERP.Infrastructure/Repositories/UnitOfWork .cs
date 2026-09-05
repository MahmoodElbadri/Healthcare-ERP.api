using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Interfaces;
using Healthcare_ERP.Infrastructure.Data;

namespace Healthcare_ERP.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly HealthDbContext _dbContext;

    public IGenericRepository<Doctor> Doctors { get; }
    public IGenericRepository<Patient> Patients { get; }
    public IGenericRepository<Medication> Medications { get; }
    public IGenericRepository<Appointment> Appointments { get; }
    public IGenericRepository<Prescription> Prescriptions { get; }
    public IGenericRepository<Speciality> Specialities { get; }
    public IGenericRepository<Diagnosis> Diagnoses { get; }

    public UnitOfWork(HealthDbContext dbContext)
    {
        _dbContext = dbContext;

        Doctors = new GenericRepository<Doctor>(_dbContext);
        Patients = new GenericRepository<Patient>(_dbContext);
        Medications = new GenericRepository<Medication>(_dbContext);
        Appointments = new GenericRepository<Appointment>(_dbContext);
        Prescriptions = new GenericRepository<Prescription>(_dbContext);
        Specialities = new GenericRepository<Speciality>(_dbContext);
        Diagnoses = new GenericRepository<Diagnosis>(_dbContext);
    }

    public async Task<int> CompleteAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}