using DataClasses.Domain;

namespace PW_DataAccessLayer.Interfaces
{
    public interface ILogInDatabaseManager
    {
        bool ValidateLogin(LogInInfo loginInfo);
        PatientInfo GetPatientInfo();
    }

    
}