﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values=_commentService.GetListCommentWithDestination();
            return View(values);
        }
     
        public IActionResult DeleteComment(int id)
        {
            var value=_commentService.TGetById(id);
            _commentService.TRemove(value);
            return RedirectToAction("Index");   

        }
    }
}
