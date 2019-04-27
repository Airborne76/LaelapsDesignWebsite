using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaelapsDesignWebsite.Controllers
{
    public class GalleryController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            //return View("Student");
            return RedirectToAction("Student");
        }

        public ActionResult Student()
        {
            List<string> students = new List<string>();
            //string path = Request.MapPath(@"./");
            string[] dir = Directory.GetFileSystemEntries($"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/wwwroot/images/Gallery/Students");          
            foreach (var file in dir)
            {
                string str = file.Replace("\\", "/");
                str = str.Substring(AppDomain.CurrentDomain.SetupInformation.ApplicationBase.Length, str.Length- AppDomain.CurrentDomain.SetupInformation.ApplicationBase.Length);
                students.Add(str);
            }
            ViewData["list"] = students;
            ViewData["data"] = "students";
            return View("Index");

        }

        public ActionResult Instructors()
        {
            List<string> teachers = new List<string>();
            //string path = Server.MapPath(@"wwwroot\images\Gallery\Teachers");

            string[] dir = Directory.GetFileSystemEntries($"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}/wwwroot/images/Gallery/Teachers");
            //string[] dir = Directory.GetFiles(path);
            foreach (var file in dir)
            {
                string str = file.Replace("\\", "/");
                str = str.Substring(AppDomain.CurrentDomain.SetupInformation.ApplicationBase.Length, str.Length - AppDomain.CurrentDomain.SetupInformation.ApplicationBase.Length);
                teachers.Add(str);
            }
            ViewData["list"] = teachers;
            ViewData["data"] = "teachers";
            return View("Index");

        }
    }
}
