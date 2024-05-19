using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Patient
    {
        public Patient() {
            doctors = new List<Doctor>();
        }
        [Key]
        public int ID{ get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Please enter a valid code.")]
        public string PatientCode { get; set; }
        public virtual ICollection<Doctor> doctors{ get; set; }
        
        public String gender { get; set; }
    }
}