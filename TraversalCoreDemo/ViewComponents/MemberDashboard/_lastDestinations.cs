using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.ViewComponents.MemberDashboard
{
    public class _lastDestinations:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _lastDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.GetLastFourDestination();
            return View(values);
        }
    }
}
