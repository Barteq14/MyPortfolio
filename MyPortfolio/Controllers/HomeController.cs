using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {

        Models.Profile profile = new Models.Profile();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Name = profile.MyName = "Bartek";
            ViewBag.Surname = profile.MySurname = "Longota";
            ViewBag.Age = profile.MyAge = 25;
            ViewBag.Email = profile.MyEmail = "b.longota2@wp.pl";
            ViewBag.PhoneNumber = profile.MyPhoneNumber = "662115529";
            ViewBag.Description = profile.MyDescription = "..............................";
            ViewBag.Education = profile.MyEducation = new List<string> { 
                "Zespół szkół nr 1 im. K.K. Baczyńskiego w Sokołowie Podlaskim - Informatyka", 
                "Uniwersytet Przyrodniczo Humanistyczny w Siedlcach - Informatyka (Studia Inżynierskie)" ,
                "Uniwersytet Przyrodniczo Humanistyczny w Siedlcach - Informatyka (Studia Magisterskie)"};
            ViewBag.Period = profile.Period = new List<string> { 
                "09.2012 - 05.2016", 
                "10.2016 - 02.2020" , 
                "02.2020 - 07.2021" };
            ViewBag.Experience = profile.MyExperience = new List<string> { 
                "10.2014 - 11.2014 (Soft, praktykant, praktyki w sklepie komputerowym, serwisowanie komputerów oraz ich naprawa)",
                "01.09.2019 - 31.09.2019 (BCoders S. A., praktykant, praktyki w firmie programistycznej, programowanie aplikacji mobilnych oraz internetowych)",
                "15.07.2020 - 08.09.2020 (Uniwersytet Przyrodniczo Humanistyczny w Siedlcach, praktykant, praktyki w ramach studiów pod kierownictwem profesora uczelni)",
                "14.12.2020 - 14.01.2021 (Uniwersytet Przyrodniczo Humanistyczny w Siedlcach, praktykant, praktyki w ramach studiów pod kierownictwem profesora uczelni)"};
            ViewBag.GoodSkills = profile.GoodSkills = new List<string> { 
                "WordPress", 
                "SQL", 
                "PL/SQL", 
                "HTML" };
            ViewBag.MediumSkills = profile.MediumSkills = new List<string> { 
                "C#", 
                "T-SQL", 
                "CSS" };
            ViewBag.LowSkills = profile.LowSkills = new List<string> { 
                "JAVA" };
            ViewBag.Certificates = profile.Certificates = new List<string> { 
                "Kwalifikacja E.12. Montaż i eksploatacja komputerów", 
                "Kwalifikacja E.13. Projektowanie lokalnych sieci komputerowych i administrowanie sieciami",
                "Kwalifikacja E.14. Tworzenie aplikacji internetowych i baz danych", 
                "Dyplom (Technik Informatyk)"};
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
