using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILogInController
    {

        ILogInDatabaseManager LogInDatabaseManager { get; set; }
        public DoctorInfoDomain DoctorInfo { get; set; }
        bool Login(LoginInfoDomain loginData);
    }
}
