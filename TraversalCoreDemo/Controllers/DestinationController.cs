using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(IDestinationService destinationService,UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _userManager= userManager;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetAll();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destid = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userid= value.Id;
            var values = _destinationService.GetDestinationWithGuide(id);
            return View(values);

        }
        public IActionResult DestinationDetails(Desnination p)
        {
            return View(p);
        }
    }
}
