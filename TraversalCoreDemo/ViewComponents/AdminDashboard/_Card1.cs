using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.AdminDashboard
{
    public class _Card1:ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
          ViewBag.c=c.Desninations.Count();
            ViewBag.a=c.Users.Count();

            return View();
        }
    }
}
