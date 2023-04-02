using Microsoft.AspNetCore.Mvc;

namespace Asp.net___intro_practica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            return View(nums);
        }



        //public string Index(int id)
        //{
        //    //return "Mirze";
        //    //var result = GetName();

        //    if(id == 0)
        //    {
        //        return "Aqshin";
        //    }

        //    return "Aqshin - " + id;
        //}

        //public string Detall(string slug,string name)
        //{
        //    return slug + " " + name;
        //}

        //private string GetName()
        //{
        //    return "Aqshin";
        //}
    }
}

