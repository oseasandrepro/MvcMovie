using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
