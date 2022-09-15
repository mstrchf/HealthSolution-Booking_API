using LoginApplication.DbContexts;
using LoginApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginApplication.Services
{
    public class DoctorService : IDoctorService
    {

        //accesss to details 
        private readonly LoginDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        public DoctorService(LoginDbContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }


        //Get All Doctors
        public Task<List<Doctor>>GetAllDoctors()
        {
            return _context.Doctors.ToListAsync();
        }




        //Get a doctor by id
        public async Task<Doctor>GetDoctor(int id)
        {
           // return await _context.Doctors.FirstAsync(x => x.Id == id);
           return await _context.Doctors.SingleOrDefaultAsync(x => x.Id == id);
        }


        //Add
        public async Task<Doctor> AddDoctor(Doctor doctor)
        {
           _context.Doctors.Add(doctor);

            await _context.SaveChangesAsync();

            return doctor;
        }



        //delete
        public async Task<int> DeleteDoctor(int id)
        {
            var item = await _context.Doctors.SingleOrDefaultAsync(x => x.Id == id);
            if(item == null)
            {
                throw new Exception("Not found" + item.Id);
            }

            _context.Doctors.Remove(item);

            return await _context.SaveChangesAsync();

        }

      


        //update
        public async Task<int>UpdateDoctor(Doctor doctor)
        {
          //var date = await _context.Doctors.AddRangeAsync(d => d.Id == doctor.Id);
            if(doctor == null)
            {
              throw new Exception("Error");
            }
            _context.Doctors.Update(doctor);
          return  await _context.SaveChangesAsync();
        }

       
    }
}
