using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using LaelapsDesignWebsite.Models;

namespace LaelapsDesignWebsite.Controllers
{
    public class AboutController : Controller
    {       
        public ActionResult Index()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher(){Img="/wwwroot/images/About/LliaYu.jpg", Name="Llia Yu",Current="Concept Artist at Blizzard Entertainment & Instructor at Brainstorm School",Education="Art Center College of Design",Previous="Riot Games"},
                new Teacher(){Img="/wwwroot/images/About/JohnPark.jpg", Name="John Pak",Current="Freelance Artist at Film Union & Founder of Brainstorm School",Education="Art Center College of Design",Previous="20th Century Fox, ILM, Naughty Dog, Sony Games, 343 Industries, Square - Enix, Adhesive Games, Gary Goddard Entertainment Design, Walt Disney Imagineering, etc"},
                new Teacher(){Img="/wwwroot/images/About/HongLy.jpg",Name="Hong Ly",Current="Concept Designer at Riot Games & Instructor at Art Center College of Design, Otis College of Art and Design",Education="Art Center College of Design",Previous="Naughty Dog, Captive Style, Spark Unlimited, NCSoft, THQ Heavy Iron, Kinesoft, Interplay, Bootprint Entertainment, Gnomon School of Visual Effects, etc"},
                new Teacher(){Img="/wwwroot/images/About/BenZhang.jpg",Name="Ben Zhang",Current="Lead Concept Artist at Blizzard Entertainment",Previous="ICE, Red 5 Shanghai Studios, Zhuozhi Times"},
                new Teacher(){Img="/wwwroot/images/About/QiuFang.jpg",Name="Qiu Fang",Current="Concept Artist at Blizzard Entertainment; Instructor at Brainstorm School",Education="Art Center College of Design"},
                new Teacher(){Img="/wwwroot/images/About/PaulKwon.jpg",Name="Paul Kwon",Current="Senior Concept Artist at Riot Games",Education="Art Center College of Design",Previous="Blizzard Entertainment"},
                new Teacher(){Img="/wwwroot/images/About/LucasAnnunziata.jpg",Name="Lucas Annunziata",Current="Environment Artist at Blizzard Entertainment",Education="Champlain College",Previous="Torn Banner Studios, Berserk Entertainment, Codename Games"},
                new Teacher(){Img="/wwwroot/images/About/K.DStanton Feng.jpg",Name="K.D Stanton Feng",Current="Concept Artist at IO Interactive",Education="Sichuan University",Previous="DMG Media, Perfect World"},
                new Teacher(){Img="/wwwroot/images/About/MitchAseltine.jpg",Name="Mitch Aseltine",Current="Concept Artist at Scribble Pad Studio",Education="Gnomon, Brainstorm School"}
            };
            ViewData["teachers"] = teachers;
            return View();
        }
    }
}