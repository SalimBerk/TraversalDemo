using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
