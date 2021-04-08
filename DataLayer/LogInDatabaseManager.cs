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

        public bool GetPatientInfo(LogInInfo loginInfo)
        {
            LoginInfoDTO loginInfoDTO = new LoginInfoDTO();

            loginInfoDTO.Username = loginInfo.Username;
            loginInfoDTO.Password = loginInfo.Password;

            patientInfoDTO = API.GetObject<PatientInfoDTO, LoginInfoDTO>("PostLoginPatient", loginInfoDTO);

            return true;
        }
    }
}