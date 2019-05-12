using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaelapsDesignWebsite.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="Enter name")]
        public string name { get; set; }
        public string company { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        [Required(ErrorMessage = "Select state")]
        public string state { get; set; }
        [Required(ErrorMessage = "Enter Zip Code")]
        public string zipCode { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public string email { get; set; }
        [Required(ErrorMessage ="Enter Phone")]
        [Phone(ErrorMessage = "Format error")]
        public string phone { get; set; }
        public string questions { get; set; }

    }
}
