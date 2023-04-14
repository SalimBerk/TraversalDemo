using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreDemo.CQRS.Commands.GuideCommands;
using TraversalCoreDemo.CQRS.Queries.GuideQueries;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var value=await _mediator.Send(new GetGuideByIdQuery(id));
            return View(value);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommand createGuideCommand)
        {
            await _mediator.Send(createGuideCommand);
            return RedirectToAction("Index");
            
        }

    }
}
