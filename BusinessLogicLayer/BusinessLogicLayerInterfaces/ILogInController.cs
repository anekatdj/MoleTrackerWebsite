using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILogInController
    {

        public DoctorInfoDomain DoctorInfo { get; set; }
        bool login(LoginInfoDomain loginData);
    }
}
