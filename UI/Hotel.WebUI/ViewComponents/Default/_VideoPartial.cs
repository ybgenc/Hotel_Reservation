using Hotel.WebUI.Dtos.VideoDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hotel.WebUI.ViewComponents.Default
{
    public class _VideoPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _VideoPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMesagge = await client.GetAsync("http://localhost:28702/api/Video");
            if (responseMesagge.IsSuccessStatusCode)
            {
                var jsonData = await responseMesagge.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultVideoDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
