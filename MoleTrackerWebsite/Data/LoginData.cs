using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class LoginDataOLD
    {
        [Required]
        [MinLength(1, ErrorMessage = "Username is too short")]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string UserName { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "password is too short")]
        public string password { get; set; }

    }
}