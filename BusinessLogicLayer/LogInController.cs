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

        public LogInController()
        {
            loginDBM = new LogInDatabaseManager();
        }
        public bool login(LoginInfoDomain loginData)
        {
            return loginDBM.VerifyLoginWithAPI(loginData);
        }

    }
}
