using LoginApplication.Models;

namespace LoginApplication.Services
{
    public interface IPatientService
    {
        Task<Patient> Appoint (Patient patient);
    }
}
