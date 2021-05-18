using System;
using System.Net;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Login;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class LogInDatabaseManager : ILogInDatabaseManager
    {
        private PatientInfoDTO patientInfoDTO;

        private IAPIService API;
        private PatientInfo patientInfo;

        public LogInDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);

            patientInfo = new PatientInfo();
        }

        public bool ValidateLogin(LogInInfo loginInfo)
        {
            LoginInfoDTO loginInfoDTO = new LoginInfoDTO();

            
            loginInfoDTO.Username = loginInfo.Username;
            loginInfoDTO.Password = loginInfo.Password;

            try
            {
                patientInfoDTO = API.GetObject<PatientInfoDTO, LoginInfoDTO>("PatientLogin", loginInfoDTO);
                patientInfo = DTOConverter.PatientInfoToDomain(patientInfoDTO);
            }
            catch (WebException e) when ((e.Response as HttpWebResponse)?.StatusCode==HttpStatusCode.NotFound)
            {
                Console.WriteLine(e);

                return false;
            }

            if (patientInfoDTO.CPR != null)
            {
                return true;
            }

            return false;

        }
        
        public PatientInfo GetPatientInfo()
        {
            patientInfo.Name = patientInfoDTO.Name;
            patientInfo.PatientID = patientInfoDTO.PatientID;
            patientInfo.PhoneNumber = patientInfoDTO.PhoneNumber;
            patientInfo.Gender = patientInfoDTO.Gender;
            patientInfo.CPR = patientInfoDTO.CPR;
            patientInfo.Email = patientInfoDTO.Email;

            return patientInfo;
        }
    }
}