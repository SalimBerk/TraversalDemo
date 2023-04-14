using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreDemo.Models;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var destinations = _destinationService.GetAll();

            var jsonCity = JsonConvert.SerializeObject(destinations);
            return Json(jsonCity);
        }
        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass
            {
                CityId=1,
                CityName="Üsküp",
                CityCountry="Makedonya"

            },
            new CityClass
            {
                CityId=2,
                CityName="Paris",
                CityCountry="Fransa"

            },
                 new CityClass
            {
                CityId=3,
                CityName="Kurtuba",
                CityCountry="İspanya"

            }
        };
        [HttpPost]

        public IActionResult AddCityDestination(Desnination destination)
        {
            destination.status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);

        }
        public IActionResult GetById(int DesninationId)
        {


            var value = _destinationService.TGetById(DesninationId);
            if(value == null)
            {
                
            }
            else
            {
                var serivalues = JsonConvert.SerializeObject(value);
                return Json(serivalues);

            }
            return View();




        }
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TRemove(values);
            return NoContent();

        }


    }


}
