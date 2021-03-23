using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DTO.LoginDTO;

namespace BusinessLogicLayer
{
    public class LogInController: ILogInController
    {
        public bool login(LoginInfoDTO data)
        {
            if (data.Username == "hej" && data.password == "hej")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool loginManager(LoginInfoDTO data)
        {
            return false;
        }
    }
}
