using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Application.CQRS.Commands.Subscribe.CreateSubscribe;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscribeController : Controller
    {
        private readonly IMediator _mediator;
        public SubscribeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateSubscribeCommandRequest model)
        {
            var value = await _mediator.Send(model);
            return Ok(value);
        }
    }
}

