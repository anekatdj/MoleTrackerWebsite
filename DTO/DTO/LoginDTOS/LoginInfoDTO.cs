using System;
using System.Collections.Generic;
using System.Text;


namespace DataClasses.DTO.LoginDTOS
{
    public class LoginInfoDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// TEST
        /// </summary>
        public LoginInfoDTO()
        {
            Username = "121212-1212";
            Password = "kodeord";
        }
    }
}
