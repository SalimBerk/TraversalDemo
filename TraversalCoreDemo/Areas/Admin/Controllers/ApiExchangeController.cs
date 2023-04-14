using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreDemo.Areas.Admin.Models;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    public class ApiExchangeController : Controller
    {
        [Area("Admin")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        { 
            List<BookingExchangeViewModel2> bookingExchangeViewModel2s= new List<BookingExchangeViewModel2>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=TRY"),
                Headers =
    {
        { "X-RapidAPI-Key", "b6a19c4b73msh78d7cdaa4765be8p1130d7jsndd2255a0a91a" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var booking = JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
                return View(booking.exchange_rates);


            }
           ;
        }
    }
}
