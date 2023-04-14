using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager sm = new SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = sm.GetAll();
            return View(values);
        }
    }
}
