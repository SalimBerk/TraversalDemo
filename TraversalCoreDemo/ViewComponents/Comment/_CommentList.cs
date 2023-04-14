using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var conn = new Context();
            ViewBag.c = conn.Comments.Where(x => x.DesninationId==id).Count();
            var values = cm.GetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
