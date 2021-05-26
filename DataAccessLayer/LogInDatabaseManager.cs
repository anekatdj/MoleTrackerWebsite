using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using APIWebServiesConnector.APIStringFabrics;
using DataClasses.Domain;
using DataClasses.DTO;

namespace DataAccessLayer
{
    public class LogInDatabaseManager : ILogInDatabaseManager
    {
        private DoctorInfoDTO doctorInfo;
        public IAPIService API { get; set; }
        public LoginInfoDTO NewLogin { get; set; }


        public LogInDatabaseManager(string stub)
        {
            API = APIFactory.GetAPI(stub);
        }

        public DoctorInfoDomain VerifyLoginWithAPI(LoginInfoDomain loginInfo)
        {
            NewLogin = loginInfo.ToDTO();

            try
            {
                doctorInfo = API.GetObject<DoctorInfoDTO, LoginInfoDTO>("MedLogin", NewLogin);
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
