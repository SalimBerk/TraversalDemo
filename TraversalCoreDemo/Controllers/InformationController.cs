using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreDemo.Controllers
{
	public class InformationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
