using Microsoft.AspNetCore.Mvc;

namespace MdxProject.UI.Controllers
{
    public sealed class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
