using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.MemberDashboard
{
    public class _MemberStatistic:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
