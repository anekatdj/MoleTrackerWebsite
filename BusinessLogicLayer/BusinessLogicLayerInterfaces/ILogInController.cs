using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;
using DataClasses.LoginDTO;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILogInController
    {
        bool login(LoginInfoDomain loginData);
    }
}
