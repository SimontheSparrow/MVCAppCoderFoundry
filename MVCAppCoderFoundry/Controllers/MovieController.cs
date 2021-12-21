using Microsoft.AspNetCore.Mvc;

namespace MVCAppCoderFoundry.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
