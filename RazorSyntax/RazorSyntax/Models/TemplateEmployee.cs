using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RazorSyntax.Models
{
    public class TemplateEmployee
    {
        public int ID { get; set; }
        [Display(Name="Please Enter your name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public bool isOnline { get; set; }
        [Display(Name="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }
    }
}