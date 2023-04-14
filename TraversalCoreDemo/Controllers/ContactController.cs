using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
       private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDTO sendMessage)
        {
            if(ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs
                {
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    MessageBody = sendMessage.MessageBody,
                    Mail= sendMessage.Mail,
                    MessageStatus = true,
                    Name = sendMessage.Name,
                    Subject = sendMessage.Subject,
                });
                return RedirectToAction("Index","Default");
            }
            return View(sendMessage);
        }
    }
}
