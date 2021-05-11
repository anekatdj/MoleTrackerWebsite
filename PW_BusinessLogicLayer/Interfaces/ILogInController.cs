

using System.Diagnostics;
using DataClasses.Domain.Login;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ILogInController
    {
        bool HandleLogin(LogInInfo loginInfo);
        PatientInfo HandlePatientInfo();
    }
}