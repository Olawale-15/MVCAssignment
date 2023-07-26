using Microsoft.AspNetCore.Mvc;

namespace MVCAssignment.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
