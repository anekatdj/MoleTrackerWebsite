using System;
using System.Net;
using APIWebServiesConnector;
using DataClasses.Domain;
using DataClasses.DTO.LoginDTOS;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class LogInDatabaseManager : ILogInDatabaseManager
    {
        private PatientInfoDTO patientInfoDTO;
        private IAPIService API;

        public LogInDatabaseManager()
        {
            API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());
            
            //API = new StubApiService();
        }

        public bool ValidateLogin(LogInInfo loginInfo)
        {
            LoginInfoDTO loginInfoDTO = new LoginInfoDTO();

            loginInfoDTO.Username = loginInfo.Username;
            loginInfoDTO.Password = loginInfo.Password;

            try
            {
                patientInfoDTO = API.GetObject<PatientInfoDTO, LoginInfoDTO>("PatientLogin", loginInfoDTO);
            }
            catch (WebException e) when ((e.Response as HttpWebResponse)?.StatusCode==HttpStatusCode.NotFound)
            {
                Console.WriteLine(e);
            }

            if (patientInfoDTO.CPR != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
        public PatientInfo GetPatientInfo()
        {
            //TODO Måske skal den laves om?

            PatientInfo patientInfo = new PatientInfo();

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