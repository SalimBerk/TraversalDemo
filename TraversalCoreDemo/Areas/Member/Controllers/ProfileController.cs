using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreDemo.Areas.Member.Models;

namespace TraversalCoreDemo.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel editViewModel = new UserEditViewModel
            {
                name = value.Name,
                surname= value.Surname,
                phonenumber=value.PhoneNumber,
                mail=value.Email

            };
            return View(editViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(p.image!=null)
            {
                var resource=Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imagename=Guid.NewGuid()+extension;
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream=new FileStream(savelocation, FileMode.Create);
                await p.image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name = p.name;
            user.Surname = p.surname;
            user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,p.password);
            var result=await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("SignIn","Login");
            }

            return View();
        }

    }
}
