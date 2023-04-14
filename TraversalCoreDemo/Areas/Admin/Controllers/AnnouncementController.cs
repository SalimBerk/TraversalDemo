using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreDemo.Areas.Admin.Models;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService,IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.GetAll());

            return View(values);
        }
       
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO announcementAdd)
        {
            if(ModelState.IsValid)
            {

                Announcement announcement = new Announcement()
                {
                    Content = announcementAdd.Content,
                    Title = announcementAdd.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                };
                _announcementService.TAdd(announcement);
                return RedirectToAction("Index","Announcement",new {area="Admin"});
                
            }
            return View(announcementAdd);
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var value=_announcementService.TGetById(id);
            _announcementService.TRemove(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
           var value= _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetById(id));  
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto announcementUpdate)
        {
            if(ModelState.IsValid)
            {
                Announcement announcement = new Announcement()
                {
                    AnnouncementId=announcementUpdate.AnnouncementId,   
                    Content = announcementUpdate.Content,
                    Title = announcementUpdate.Title,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())

                };
               _announcementService.TUpdate(announcement);
                return RedirectToAction("Index");
            }
            
            return View(announcementUpdate);
        }

    }
}
