using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataClasses.Domain
{
    public class LoginInfoDomain
    {
        [Required]
        [MinLength(1, ErrorMessage = "Brugernavn er for kort")]
        [StringLength(10, ErrorMessage = "Brugernavn er for langt")]
        public string Username { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Adgangskode er for kort")]
        public string Password { get; set; }
    }
}
