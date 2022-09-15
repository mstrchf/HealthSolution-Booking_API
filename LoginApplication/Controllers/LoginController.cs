using LoginApplication.Models;
using LoginApplication.Services;
using LoginApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LoginApplication.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LoginController: ControllerBase
    {
        private readonly LoginService _service;

        public LoginController(ILoginService service)
        {
            _service = (LoginService)service;
        }


        [HttpPost("login")]
        public async Task<Profile> Login(User user)
        {
            return await _service.Login(user);
        }

        
        [HttpPost("Register")]
        public async Task<Profile>Register(UserLogin user)
        {
            return await _service.Register(user);
        }
   
    }
}
