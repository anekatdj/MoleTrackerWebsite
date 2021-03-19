using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoleTrackerWebsite.Models
{
    public class LogInInfo
    {
        [Required]
        [MinLength(1, ErrorMessage = "Username is too short")]
        [StringLength(10, ErrorMessage = "Username is too long.")]
        public string Username { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Password is too short")]
        public string Password { get; set; }
    }
}
