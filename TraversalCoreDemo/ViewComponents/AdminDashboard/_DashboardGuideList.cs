using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.AdminDashboard
{
    public class _DashboardGuideList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
