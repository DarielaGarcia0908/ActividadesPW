using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using Unidad1_Actividad2.Models;

namespace Unidad1_Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(float c1, float c2, float c3)
        {
            CalificacionViewModel cal = new CalificacionViewModel();

            cal.Calif1 = c1;
            cal.Calif2 = c2;
            cal.Calif3 = c3;

            return View(cal);
        }
    }
}
