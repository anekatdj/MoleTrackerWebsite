using DataClasses.Domain.Login;

namespace PW_DataAccessLayer.Interfaces
{
    public interface ILogInDatabaseManager
    {
        public bool LoginFailed { get; set; }
        bool ValidateLogin(LogInInfo loginInfo);
        PatientInfo GetPatientInfo();
    }

    
}