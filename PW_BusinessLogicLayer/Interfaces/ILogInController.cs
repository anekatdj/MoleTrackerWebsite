

using System.Diagnostics;
using DataClasses.Domain.Login;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ILogInController
    {
        public bool LoginFailed { get; set; }
        bool HandleLogin(LogInInfo loginInfo);
        PatientInfo HandlePatientInfo();
    }
}