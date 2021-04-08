using System;
using DataClasses.Domain;
using DataLayer;
using LogicLayer.Interfaces;

namespace LogicLayer
{
    public class LogInController : ILogInController
    {
        private ILogInDatabaseManager logInDatabaseManager;
        public bool HandleLogin(LogInInfo loginInfo)
        {
            //AK leger
            logInDatabaseManager = new LogInDatabaseManager();
            return logInDatabaseManager.GetPatientInfo(loginInfo);
            //return true;

            //Fra tidligere
            {
                if (loginInfo.Username == "1212121212" && loginInfo.Password == "kodeord")
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
