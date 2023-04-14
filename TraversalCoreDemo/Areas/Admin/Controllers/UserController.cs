﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _userService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService userService, IReservationService reservationService)
        {
            _userService = userService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _userService.GetAll();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var value= _userService.TGetById(id);
            _userService.TRemove(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var value = _userService.TGetById(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _userService.TUpdate(appUser);
            return RedirectToAction("Index");

        }
        public IActionResult CommentUser()
        {
            return View();
        }
        public IActionResult ReservationUser(int id)
        {
            var values=_reservationService.GetListWithReservtionByAccepted(id);
            return View(values);
        }
    }
}
