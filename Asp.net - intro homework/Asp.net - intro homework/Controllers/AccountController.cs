using Microsoft.AspNetCore.Mvc;

namespace Asp.net___intro_homework.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<string> names = new List<string>() { "Cavid", "Farid", "Mubariz" };

            return View(names);
        }
    }
}
