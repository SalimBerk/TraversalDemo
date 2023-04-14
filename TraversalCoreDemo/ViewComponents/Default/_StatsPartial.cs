using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.Default
{
    public class _StatsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Desninations.Count();
            ViewBag.v2=c.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
