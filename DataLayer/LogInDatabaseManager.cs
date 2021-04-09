using System;
using APIWebServiesConnector;
using DataClasses.Domain;
using DataClasses.DTO.LoginDTOS;

namespace DataLayer
{
    public class LogInDatabaseManager : ILogInDatabaseManager
    {
        private PatientInfoDTO patientInfoDTO;
        private IAPIService API;

        public LogInDatabaseManager()
        {
            API = new StubApiService();
        }

        public bool ValidateLogin(LogInInfo loginInfo)
        {
            LoginInfoDTO loginInfoDTO = new LoginInfoDTO();

            loginInfoDTO.Username = loginInfo.Username;
            loginInfoDTO.Password = loginInfo.Password;

            //TODO Mangler at teste med testbrugeren
            try
            {
                patientInfoDTO = API.GetObject<PatientInfoDTO, LoginInfoDTO>("PostLoginPatient", loginInfoDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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