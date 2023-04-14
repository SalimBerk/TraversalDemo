using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.MemberLayout
{
    public class _MemberLayoutSidebar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
