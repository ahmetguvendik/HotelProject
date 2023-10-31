using System;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Frontend.ViewComponents.Default
{
	public class VideoPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

