﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoleTrackerWebsite.Models
{

        public class LogInInfo
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
