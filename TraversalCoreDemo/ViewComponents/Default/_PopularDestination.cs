using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.Default
{
    public class _PopularDestination:ViewComponent
    {
        DestinationManager dm = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = dm.GetAll();
            return View(values);
        }
    }
}
