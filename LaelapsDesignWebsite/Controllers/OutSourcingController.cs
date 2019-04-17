using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaelapsDesignWebsite.Controllers
{
    public class OutSourcingController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            return Redirect("http://www.laelapsdesign.com");
            //return View();
        }
    }
}
