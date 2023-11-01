using Hotel.Frontend.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotel.Frontend.ViewComponents.Default
{
    public class TeamPartial : ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;
        public TeamPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7105/Staff");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetStaffViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

