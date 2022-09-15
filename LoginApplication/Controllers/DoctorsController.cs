using LoginApplication.Models;
using LoginApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginApplication.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _service;
        public DoctorsController(IDoctorService service)
        {
            _service = service;
        }


        //Get All Doctors
        [HttpGet]
        public Task<List<Doctor>>GetAllDoctors()
        {
            return _service.GetAllDoctors();
        }

        //Get a Doctor  By Id
        [HttpGet("{id}")]
        public Task<Doctor>GetDoctor([FromRoute] int id)
        {
            return _service.GetDoctor(id);
        }


        //add Doctor
        [HttpPost]
        public Task<Doctor>AddDoctor([FromBody] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                return _service.AddDoctor(doctor);
            }
            throw new Exception("Error");
            
        }


        //Delete Doctor by Id
        [HttpDelete("{id}")]
        public Task<int> DeleteDoctor([FromRoute] int id)
        {
            if (ModelState.IsValid)
            {
                return _service.DeleteDoctor(id);

            }
            throw new Exception("Not Deleted");
        }



        //Update a Doctor by Id
        [HttpPut("{id}")]

        public Task<int> UpdateDoctor([FromRoute] int id, Doctor doctor)
        {

            doctor.Id = id;

            return _service.UpdateDoctor(doctor);

        }


    }
}
