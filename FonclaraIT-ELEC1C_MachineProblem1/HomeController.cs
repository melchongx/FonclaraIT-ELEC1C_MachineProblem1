using Microsoft.AspNetCore.Mvc;

namespace FonclaraIT_ELEC1C_MachineProblem1
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
