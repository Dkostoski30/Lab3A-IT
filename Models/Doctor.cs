using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Doctor
    {
        public Doctor () {
            patients = new List<Patient>() { };
        }
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Patient> patients { get; set; }
        [Required]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Please enter a valid age.")]
        public String Age { get; set; }

    }
}