using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.AdminDashboard
{
    public class _TotalRevenue:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
