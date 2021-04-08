using APIWebServiesConnector;
using DataClasses.Domain;
using DataClasses.DTO.LoginDTOS;

namespace DataLayer
{
    class LogInDatabaseManager : ILogInDatabaseManager
    {
        private PatientInfoDTO patientInfoDTO;
        //private IAPIService API;

        public LogInDatabaseManager()
        {
            //API = new StubApiService();
        }


        public bool GetPatientInfo(LogInInfo loginInfo)
        {
            return true;
        }
    }
}