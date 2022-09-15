using LoginApplication.Models;
using LoginApplication.ViewModel;

namespace LoginApplication.Services
{
    public interface ILoginService
    {
        Task<Profile> Login(User user);
        Task<Profile> Register(UserLogin user);
    }
}
