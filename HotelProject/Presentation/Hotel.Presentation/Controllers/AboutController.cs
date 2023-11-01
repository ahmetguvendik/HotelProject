using Hotel.Application.CQRS.Queries.About.GetAllAbout;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AboutController : Controller
    {
        private readonly IMediator _mediator;
        public AboutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromHeader]GetAllAboutRequest model)
        {
            var value = await _mediator.Send(model);
            return Ok(value);
        }
    }
}

