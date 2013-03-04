using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class Contact
    {
        [Required]
        public string FullName { get; set; }

        [EmailAddress]
        [StringLength(50,MinimumLength=10)]
        public string Email { get; set; }
    }
}