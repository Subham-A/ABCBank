using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DetailsViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}