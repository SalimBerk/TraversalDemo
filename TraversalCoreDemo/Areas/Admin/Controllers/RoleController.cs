using DocumentFormat.OpenXml.VariantTypes;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreDemo.Areas.Admin.Models;
using TraversalCoreDemo.Models;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager; 

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var values=_roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        [Route("CreateRole")]
        public IActionResult CreateRole()
        {
            return View();
        }
        
        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel roleViewModel)
        {
            AppRole role = new AppRole()
            {
                Name = roleViewModel.RoleName,
            };
            var result=await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value=_roleManager.Roles.FirstOrDefault(x => x.Id == id);   
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        [Route("UpdateRole/{id}")]
        public IActionResult UpdateRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel()
            {
                RoleID = value.Id,
                RoleName = value.Name
            };
            return View(updateRoleViewModel);

        }
        [HttpPost]
        [Route("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var value=_roleManager.Roles.FirstOrDefault(p=>p.Id==updateRoleViewModel.RoleID);
            value.Name=updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(value);
           return RedirectToAction("Index");
            

        }
        [Route("UserList")]
        public IActionResult UserList()
        {
            var values=_userManager.Users.ToList();
            return View(values);
        }
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["userid"] = user.Id;
            var roles=_roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> assignViewModels = new List<RoleAssignViewModel>();
            foreach (var role in roles)
            {
                RoleAssignViewModel roleAssignViewModel=new RoleAssignViewModel();
                roleAssignViewModel.RoleId=role.Id;
                roleAssignViewModel.RoleName = role.Name;
                roleAssignViewModel.RoleExist = userRoles.Contains(role.Name);
                assignViewModels.Add(roleAssignViewModel);


            }
            return View(assignViewModels);
        }
        [HttpPost]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> assignViewModels)
        {
            var userid = TempData["userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == (int)userid);
            foreach (var item in assignViewModels)
            {
                if(item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }

            }
            return RedirectToAction("UserList");

        }
    }
    
}
