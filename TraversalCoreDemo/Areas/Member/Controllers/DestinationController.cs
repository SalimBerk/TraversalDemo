using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DestinationController : Controller
    {
        
        DestinationManager dm = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = dm.GetAll();
            return View(values);
        }
        public IActionResult GetCitiesSearchByName(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var values = from x in dm.GetAll() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(p => p.City.Contains(searchString));
            }
            return View(values.ToList());

        }
    }
}
