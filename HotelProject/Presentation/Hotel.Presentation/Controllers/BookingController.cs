using Hotel.Application.CQRS.Commands.Booking.CreateBooking;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : Controller
    {
        private readonly IMediator _mediator;
        public BookingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateBookingCommandRequest model)
        {
            var value = await _mediator.Send(model);
            return Ok(value);
        }
    }
}

