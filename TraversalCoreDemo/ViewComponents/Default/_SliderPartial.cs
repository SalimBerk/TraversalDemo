using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace TraversalCoreDemo.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
