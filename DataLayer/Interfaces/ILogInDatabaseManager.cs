using DataClasses.Domain;

namespace DataLayer
{
    public interface ILogInDatabaseManager
    {
        bool ValidateLogin(LogInInfo loginInfo);
    }

    
}