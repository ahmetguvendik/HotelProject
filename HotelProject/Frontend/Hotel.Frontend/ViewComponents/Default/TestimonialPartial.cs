using System;
using Hotel.Frontend.Models.About;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Hotel.Frontend.Models.Testimonial;

namespace Hotel.Frontend.ViewComponents.Default
{
	public class TestimonialPartial : ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;
        public TestimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7105/Testimonial");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetTestimonialViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

