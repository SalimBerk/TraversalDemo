using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreDemo.CQRS.Commands.DestinationCommands;
using TraversalCoreDemo.CQRS.Handlers.DestinationHandlers;
using TraversalCoreDemo.CQRS.Queries.DestinationQueries;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
        private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler getAllDestinationQueryHandler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler,CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
            _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler= updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id) {
            var values = _getDestinationByIdQueryHandler.queryResult(new GetDestinationByIdQuery(id));
            return View(values);
        
        
        }
        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand updateDestinationCommand)
        {
            _updateDestinationCommandHandler.handle(updateDestinationCommand);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult AddDestination()
        {

            return View();

        }
        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand createDestinationCommand)
        {
             _createDestinationCommandHandler.handle(createDestinationCommand);

            return RedirectToAction("Index");

        }
        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");

        }        

        
    }
}
