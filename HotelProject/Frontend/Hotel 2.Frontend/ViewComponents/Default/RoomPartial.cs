using System;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Frontend.ViewComponents.Default
{
	public class RoomPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

