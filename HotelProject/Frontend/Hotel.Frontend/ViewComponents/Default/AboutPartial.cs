using System;
using Hotel.Frontend.Models.About;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotel.Frontend.ViewComponents.Default
{
	public class AboutPartial : ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;
        public AboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7105/About");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetAboutViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

