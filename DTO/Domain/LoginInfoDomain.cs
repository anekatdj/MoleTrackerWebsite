using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DataClasses.LoginDTO;

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

        public LoginInfoDTO ToDTO()
        {
            LoginInfoDTO loginInfoDto = new LoginInfoDTO()
            {
                Username = Username,
                Password = Password
            };
            return loginInfoDto;
        }
    }
}
