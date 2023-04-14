using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Desnination desnination)
        {
            desnination.status = true;
            destinationManager.TAdd(desnination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = destinationManager.TGetById(id);
            destinationManager.TRemove(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = destinationManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Desnination desnination)
        {
            destinationManager.TUpdate(desnination);
            return RedirectToAction("Index");
        }
    }
}
