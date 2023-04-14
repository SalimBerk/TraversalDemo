using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        FeatureManager fm = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            //ViewBag.image1=fm
            return View();
        }
    }
}
