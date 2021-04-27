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
        private ILogInDatabaseManager loginDBM;
        public DoctorInfoDomain DoctorInfo { get; set; }

        public LogInController()
        {
            loginDBM = new LogInDatabaseManager();
        }
        public bool Login(LoginInfoDomain loginData)
        {
            DoctorInfo = loginDBM.VerifyLoginWithAPI(loginData);

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
