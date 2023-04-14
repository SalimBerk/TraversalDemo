using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
