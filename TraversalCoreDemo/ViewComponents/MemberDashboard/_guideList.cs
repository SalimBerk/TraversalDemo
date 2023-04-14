using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.MemberDashboard
{
    public class _guideList:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values=guideManager.GetAll();
            return View(values);
        }
    }
}
