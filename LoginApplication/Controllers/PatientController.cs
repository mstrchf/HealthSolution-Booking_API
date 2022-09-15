using LoginApplication.Models;
using LoginApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginApplication.Controllers
{


    [ApiController]
    [Route("api[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _service;
        public PatientController( IPatientService service)
        {
            _service = service;
        }

        [HttpPost("Appoint")]
        public  Task<Patient>Appoint(Patient patient)
        {
            return _service.Appoint(patient);
        }
    }
}
