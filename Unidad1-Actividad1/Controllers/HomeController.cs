using Microsoft.AspNetCore.Mvc;

namespace Unidad1_Actividad1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MiPerfil()
        {
            return View();
        }
    }
}
