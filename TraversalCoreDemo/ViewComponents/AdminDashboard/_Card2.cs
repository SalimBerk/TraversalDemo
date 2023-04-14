using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.AdminDashboard
{
    public class _Card2:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
