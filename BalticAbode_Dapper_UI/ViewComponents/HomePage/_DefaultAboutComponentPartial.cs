using BalticAbode_Dapper_UI.Dtos.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace BalticAbode_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultAboutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44348/api/AboutDetail");
            var responseMessage2 = await client2.GetAsync("https://localhost:44348/api/Services");

            if (responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();

                var value = JsonConvert.DeserializeObject<List<ResultAboutDetailDto>>(jsonData);
                var value2 = JsonConvert.DeserializeObject<List<ResultAboutDetailDto>>(jsonData2);

                ViewBag.title = value.Select(x => x.Title).FirstOrDefault();
                ViewBag.subtitle = value.Select(x => x.SubTitle).FirstOrDefault();
                ViewBag.desc1 = value.Select(x => x.Description1).FirstOrDefault();
                ViewBag.desc2 = value.Select(x => x.Description1).FirstOrDefault();
                return View(value2);
            }
            return View();

        }
    }
}
