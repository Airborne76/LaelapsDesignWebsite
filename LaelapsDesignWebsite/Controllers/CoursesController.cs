using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaelapsDesignWebsite.Controllers
{
    public class CoursesController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            Dictionary<string, string> Courses = new Dictionary<string, string>()
            {
                {"ENVIRONMENT DESIGN","/wwwroot/images/Courses/1.png" },
                {"ADVANCED ENVIRONMENT DESIGN","/wwwroot/images/Courses/2.png" },
                {"CHARACTER DESIGN I","/wwwroot/images/Courses/3.png" },
                {"CHARACTER DESIGN II","/wwwroot/images/Courses/4.jpg" },
                {"FUNDAMENTALS OF CHARACTER DESIGN","/wwwroot/images/Courses/5.jpg" },
                {"WEAPONS & PROPS FOR GAMES","/wwwroot/images/Courses/6.png" },
                {"ENTERTAINMENT DEISGN","/wwwroot/images/Courses/7.png" },
                {"ADVANCED MENTORSHIP","/wwwroot/images/Courses/8.png" }
            };
            ViewData["list"] = Courses;
            return View();
        }
    }
}
