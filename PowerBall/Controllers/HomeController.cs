using Microsoft.AspNetCore.Mvc;

namespace Powerball_Ticket_Generator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
