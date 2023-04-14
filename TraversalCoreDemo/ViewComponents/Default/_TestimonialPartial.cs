using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = tm.GetAll();
            return View(values);
        }
    }
}
