using DataClasses.Domain;

namespace DataLayer
{
    public interface ILogInDatabaseManager
    {
        bool GetPatientInfo(LogInInfo loginInfo);
    }

    
}