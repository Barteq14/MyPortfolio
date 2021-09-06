using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Profile
    {
        public string MyName { get; set; }
        public string MySurname { get; set; }
        public int MyAge { get; set; }
        public string MyEmail { get; set; }
        public string MyPhoneNumber { get; set; }
        public string MyDescription { get; set; }
        public List<string> MyExperience { get; set; }
        public List<string> MyEducation { get; set; }
        public List<string> Period { get; set; }
        public List<string> Degree { get; set; }
        public List<string> LowSkills { get; set; }
        public List<string> MediumSkills { get; set; }
        public List<string> GoodSkills { get; set; }
        public List<string> Certificates { get; set; }


    }
}
