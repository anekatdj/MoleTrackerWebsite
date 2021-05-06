using System;
using DataClasses.Domain.Login;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class LogInController : ILogInController
    {
        private ILogInDatabaseManager logInDatabaseManager;

        public LogInController()
        {
            //AK leger
            logInDatabaseManager = new LogInDatabaseManager();
        }

        public bool HandleLogin(LogInInfo loginInfo)
        {
            return logInDatabaseManager.ValidateLogin(loginInfo);
            //return true;
        }

        //public PatientInfo HandlePatientInfo()
        //{
        //    return logInDatabaseManager.GetPatientInfo();
        //}
    }
}
