using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Areas.Member.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        [Area("Member")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
