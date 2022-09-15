using LoginApplication.DbContexts;
using LoginApplication.Models;


namespace LoginApplication.Services
{
    public class BookingService : IBookingService
    {
        private readonly LoginDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;


        public BookingService(LoginDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _contextAccessor = accessor;
        }



        
        public async Task<Booking> Book(Booking user)
        {
            _context.Booking.Add(user);

            await _context.SaveChangesAsync();

            return user;
        }
    }
}
