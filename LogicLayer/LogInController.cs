using System;
using DataClasses.Domain;
using LogicLayer.Interfaces;

namespace LogicLayer
{
    public class LogInController : ILogInController
    {
        private DataLayer.ILogInDatabaseManager logInDatabaseManager;
        public bool HandleLogin(LogInInfo loginInfo)
        {
            //AK leger
            //return logInDatabaseManager.GetPatientInfo(loginInfo);
            //return true;


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
