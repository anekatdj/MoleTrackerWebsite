using DataClasses.Domain;

namespace DataClasses.LoginDTO
{
    public class LoginInfoDTO
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginInfoDomain ToDomain()
        {
            LoginInfoDomain loginInfoDomain = new LoginInfoDomain()
            {
                Username = Username,
                Password = Password
            };
            return loginInfoDomain;
        }
    }
}
