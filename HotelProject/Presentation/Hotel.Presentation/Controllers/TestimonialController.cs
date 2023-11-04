using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Application.CQRS.Queries.Testimonial.GetAllTestimonial;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestimonialController : Controller
    {
        private readonly IMediator _mediator;

        public TestimonialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromHeader] GetAllTestimonialQueryRequest model)
        {
            var value = await _mediator.Send(model);
            return Ok(value);
        }
    }
}

