using System;
using DTO.LoginDTOS;
using LogicLayer.Interfaces;

namespace LogicLayer
{
    public class LogInController : ILogInController
    {
        public bool HandleLogin(LoginInfoDTO loginInfo)
        {
            //return true;
            {
                if (loginInfo.Username == "121212-1212" && loginInfo.Password == "kodeord")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
