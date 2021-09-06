using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyPortfolio.Controllers
{
    public class ProfileController : Controller
    {
        Models.Profile profile = new Models.Profile();
        public IActionResult Index()
        {
            //List<string> lista = new List<string>();

            ViewBag.Name = profile.MyName = "Bartek";
            ViewBag.Surname = profile.MySurname = "Longota";
            ViewBag.Age = profile.MyAge = 25;
            ViewBag.Email = profile.MyEmail = "b.longota2@wp.pl";
            ViewBag.PhoneNumber = profile.MyPhoneNumber = "662115529";
            ViewBag.Description = profile.MyDescription = "..............................";
            /*ViewBag.Education = profile.MyEducation = "............................";*/
            /*ViewBag.Experience = profile.MyExperience = "................................";*/
            ViewBag.LowSkills = profile.LowSkills = new List<string> { "JAVA" };
            ViewBag.MediumSkills = profile.MediumSkills = new List<string> { "C#", "T-SQL", "CSS" };
            ViewBag.GoodSkills = profile.GoodSkills = new List<string> {  "WordPress", "SQL", "PL/SQL",  "HTML"};

            return View();
        }
    }
}
