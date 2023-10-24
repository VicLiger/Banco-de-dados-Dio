using Microsoft.AspNetCore.Mvc;

namespace Port.Controllers
{
    public class PortController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
