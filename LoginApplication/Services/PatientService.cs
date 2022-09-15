using LoginApplication.DbContexts;
using LoginApplication.Models;

namespace LoginApplication.Services
{
    public class PatientService : IPatientService
    {
        private readonly LoginDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        public PatientService(LoginDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _contextAccessor = accessor;
        }
        public Task<Patient>Appoint(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
