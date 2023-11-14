using System.Text;
using Hotel.Frontend.Models.Booking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Frontend.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult CreateBookingPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookingPartial(CreateBookingViewModel createBookingViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            createBookingViewModel.Statues = "Onay Bekliyor";
            var jsonData = JsonConvert.SerializeObject(createBookingViewModel);
            var stringContent = new StringContent(jsonData, encoding: Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7105/Booking", stringContent);
            return RedirectToAction("Index", "Booking");
        }

    }
}

