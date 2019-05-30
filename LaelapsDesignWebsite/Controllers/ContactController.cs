using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using LaelapsDesignWebsite.Models;
using LaelapsDesignWebsite.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaelapsDesignWebsite.Controllers
{
    public class ContactController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            ViewData["msg"] = "";
            return View();
        }
        public ActionResult Submit(Contact model)
        {
            if (ModelState.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"name: {model.name}. <br />");
                sb.Append($"company: {model.company}. <br />");
                sb.Append($"address: {model.address}. <br />");
                sb.Append($"city: {model.city}. <br />");
                sb.Append($"state: {model.state}. <br />");
                sb.Append($"zipCode: {model.zipCode}. <br />");
                sb.Append($"email: {model.email}. <br />");
                sb.Append($"phone: {model.phone}. <br />");
                sb.Append($"questions: {model.questions}. <br />");
                string message = sb.ToString();
                string errMessage;
                if (MailService.GetInstance().SendMail(message,out errMessage))
                {
                    ViewData["msg"] = "Message has been send";
                    return View("Index");
                }
                else
                {
                    ViewData["msg"] = $"Error:{errMessage}"; 
                    return View("Index");
                }                
            }
            else
            {
                ViewData["msg"] = "";
                return View("Index");
            }
        }
    }
}
