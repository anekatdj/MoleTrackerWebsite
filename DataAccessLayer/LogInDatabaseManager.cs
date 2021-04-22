using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using APIWebServiesConnector.APIStringFabrics;
using DataClasses;
using DataClasses.Domain;
using DataClasses.DTO;

namespace DataAccessLayer
{
    public class LogInDatabaseManager : ILogInDatabaseManager
    {
        private DoctorInfoDTO doctorInfo;
        private IAPIService API;


        public LogInDatabaseManager()
        {
            API = APIFactory.GetAPI("");
        }

        public DoctorInfoDomain VerifyLoginWithAPI(LoginInfoDomain loginInfo)
        {
            LoginInfoDTO newLogin = loginInfo.ToDTO();

            try
            {
                doctorInfo = API.GetObject<DoctorInfoDTO, LoginInfoDTO>("MedLogin", newLogin);
                 var doctorInfoDomain = DTOConverter.DoctorInfoToDomain(doctorInfo);
                 return doctorInfoDomain;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
