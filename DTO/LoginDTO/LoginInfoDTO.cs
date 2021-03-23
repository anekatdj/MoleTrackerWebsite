using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DTO.LoginDTO
{
    public class LoginInfoDTO
    {
        [Required]
        [MinLength(1, ErrorMessage = "CPR-nummer er for kort")]
        [StringLength(10, ErrorMessage = "CPR-nummer er for langt")]
        public string Username { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Kodeord er for kort")]
        public string password { get; set; }
    }
}
