using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Hospital
    {
        public Hospital() {
            doctors = new List<Doctor>() { };
        }

        [Key]
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Address { get; set; }
        public virtual ICollection<Doctor> doctors { get; set; }
        [Required]
        public String image_url { get; set; }
    }
}