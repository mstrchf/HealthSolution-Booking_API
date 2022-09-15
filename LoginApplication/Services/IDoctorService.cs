using LoginApplication.Models;

namespace LoginApplication.Services
{
    public interface IDoctorService
    {
        Task<List<Doctor>>GetAllDoctors();
        Task<Doctor>GetDoctor(int id);
        Task<Doctor>AddDoctor(Doctor doctor);
        Task<int>UpdateDoctor( Doctor doctor);
        Task<int>DeleteDoctor(int id);
    }
}
