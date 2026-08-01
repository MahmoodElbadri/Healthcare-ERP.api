using Healthcare_ERP.Domain.Entities;

namespace Healthcare_ERP.Domain.Interfaces;

public interface IUnitOfWork:IDisposable
{
    IGenericRepository<Doctor> Doctors { get; }
    IGenericRepository<Patient> Patients { get; }
    IGenericRepository<Medication> Medications { get; }
    IGenericRepository<Appointment> Appointments { get; }
    IGenericRepository<Prescription> Prescriptions { get; }

    Task<int> CompleteAsync();

}
