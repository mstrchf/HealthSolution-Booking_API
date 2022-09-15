using LoginApplication.Models;
using LoginApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LoginApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController :ControllerBase
    {
        private readonly IBookingService _service;
        public BookingController(IBookingService service)
        {
            _service = service;
        }



       // [HttpGet]

        [HttpPost]
        public  Task<Booking>Book([FromBody] Booking booking)
        {
            if (ModelState.IsValid)
            {
                return _service.Book(booking);

            }

            throw new Exception("Not Found Try Again");
        }


    }
}
