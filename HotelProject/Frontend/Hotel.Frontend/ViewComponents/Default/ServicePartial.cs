using System;
using Hotel.Frontend.Models.About;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Hotel.Frontend.Models.Service;

namespace Hotel.Frontend.ViewComponents.Default
{
	public class ServicePartial : ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;
        public ServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7105/Service");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetServiceViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

