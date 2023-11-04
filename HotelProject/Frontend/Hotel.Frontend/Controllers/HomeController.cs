using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Hotel.Frontend.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using Hotel.Frontend.Models.Newsletter;

namespace Hotel.Frontend.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    public HomeController(ILogger<HomeController> logger,IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
        return View();
    }


}

