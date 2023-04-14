using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.MemberDashboard
{
    public class _platformSetting:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
