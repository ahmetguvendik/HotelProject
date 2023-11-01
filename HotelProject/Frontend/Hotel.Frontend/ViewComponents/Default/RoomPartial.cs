using System;
using Hotel.Frontend.Models.About;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Hotel.Frontend.Models.Room;

namespace Hotel.Frontend.ViewComponents.Default
{
	public class RoomPartial : ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;
        public RoomPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7105/Room");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetRoomViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

