using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaelapsDesignWebsite.Controllers
{
    public class PortfolioPrepController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            List<string> PortfolioPrep = new List<string>()
            {
                "/wwwroot/images/PrortfolioPrep/LOGO-1.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-2.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-3.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-4.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-5.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-6.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-7.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-8.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-9.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-10.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-11.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-12.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-13.png",
                "/wwwroot/images/PrortfolioPrep/LOGO-14.png"
            };
            ViewData["list"] = PortfolioPrep;
            return View();
        }

    }
}
