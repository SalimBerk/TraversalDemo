using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.MemberDashboard
{
    public class _ProfileInformation:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        public _ProfileInformation(UserManager<AppUser> userManager) {
            _userManager = userManager;    

        }    
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.username = value.Name + " " + value.Surname;
            ViewBag.email=value.Email;

            return View();
        }
    }
}
