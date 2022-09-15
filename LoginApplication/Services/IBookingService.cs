using LoginApplication.Models;

namespace LoginApplication.Services
{
    public interface IBookingService
    {
        Task<Booking> Book(Booking user);
      
    }
}
