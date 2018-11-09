using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SnekWebsite.Models
{
    //Contact Info Model


    public class Contact_Info
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter your email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please select a subject")]
        public int Subject { get; set; }

        [Required(ErrorMessage ="Please enter your message")]
        public string Message { get; set; }
    }
}