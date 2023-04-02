using Microsoft.AspNetCore.Mvc;

namespace Asp.net___intro_practica.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
