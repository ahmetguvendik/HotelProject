using Hotel.Application.CQRS.Queries.Room.GetAllRoom;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : Controller
    {
        // GET: /<controller>/
        private readonly IMediator _mediator;
        public RoomController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromHeader] GetAllRoomQueryRequest model)
        {
            var list = await _mediator.Send(model);
            return Ok(list);
        }
    }
}

