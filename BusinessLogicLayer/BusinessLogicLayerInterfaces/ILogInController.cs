using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.LoginDTO;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILogInController
    {
        bool login(LoginInfoDTO data);
    }
}
