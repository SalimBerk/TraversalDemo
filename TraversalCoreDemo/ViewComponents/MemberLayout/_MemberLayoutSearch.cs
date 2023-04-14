using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TraversalCoreDemo.ViewComponents.MemberLayout
{
    public class _MemberLayoutSearch:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
