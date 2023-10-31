using System;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Frontend.ViewComponents.Default
{
	public class TestimonialPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

