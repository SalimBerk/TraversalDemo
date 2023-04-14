using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[Action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var valuesName = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = valuesName.Name + " " + valuesName.Surname;
            ViewBag.userImage = valuesName.ImageUrl;
            
            return View();
        }
        public async Task<IActionResult> MemberDashboard()
        {
            return View();
        }
    }
}
