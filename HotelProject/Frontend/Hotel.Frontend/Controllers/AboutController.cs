using System.Text;
using Hotel.Frontend.Models.Newsletter;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Frontend.Controllers
{
    public class AboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult NewsletterPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> NewsletterPartial(CreateNewsletterViewModel createNewsletterViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createNewsletterViewModel);
            var stringContent = new StringContent(jsonData, encoding: Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7105/Subscribe", stringContent);
            return RedirectToAction("Index","About");   
        }
    }
}

