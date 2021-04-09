using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using DataClasses.LoginDTO;
using 

namespace DataAccessLayer
{
    public class LogInDatabaseManager: ILogInDatabaseManager
    {
        private DoctorInfoDTO doctorInfo;
        private IAPIService API;


        public LogInDatabaseManager()
        {
            API = new StubApiService();
        }

        public bool VerifyLoginWithAPI(LogInInfo loginInfo)
        {
            LoginInfoDTO newLogin = new LoginInfoDTO();

            newLogin.Username = loginInfo.Username;
            newLogin.Password = loginInfo.Password;

            try
            {
                doctorInfo = API.GetObject<DoctorInfoDTO, LoginInfoDTO>("PostLoginDoctor", newLogin);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            if (doctorInfo != null)
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
