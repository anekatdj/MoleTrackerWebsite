using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class LogInController: ILogInController
    {
        public ILogInDatabaseManager LogInDatabaseManager { get; set; }
        public DoctorInfoDomain DoctorInfo { get; set; }

        public LogInController()
        {
            LogInDatabaseManager = new LogInDatabaseManager("");
        }
        public bool Login(LoginInfoDomain loginData)
        {
            DoctorInfo = LogInDatabaseManager.VerifyLoginWithAPI(loginData);

            if (DoctorInfo != null)
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
