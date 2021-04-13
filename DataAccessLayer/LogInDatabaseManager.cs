using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using APIWebServiesConnector.APIStringFabrics;
using DataClasses;
using DataClasses.Domain;
using DataClasses.LoginDTO;

namespace DataAccessLayer
{
    public class LogInDatabaseManager : ILogInDatabaseManager
    {
        private DoctorInfoDTO doctorInfo;
        private IAPIService API;


        public LogInDatabaseManager()
        {
            API = new ApiService(APIStringFabric.GetDeveloperAPIString());
        }

        public bool VerifyLoginWithAPI(LoginInfoDomain loginInfo)
        {
            LoginInfoDTO newLogin = new LoginInfoDTO();

            newLogin.Username = loginInfo.Username;
            newLogin.Password = loginInfo.Password;

            try
            {
                doctorInfo = API.GetObject<DoctorInfoDTO, LoginInfoDTO>("MedLogin", newLogin);
            }
            catch (Exception e)
            {
                return false;
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
