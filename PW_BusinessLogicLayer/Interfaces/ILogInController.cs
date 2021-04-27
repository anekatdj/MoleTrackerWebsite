

using System.Diagnostics;
using DataClasses.Domain;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ILogInController
    {
        bool HandleLogin(LogInInfo loginInfo);
        //PatientInfo HandlePatientInfo();
    }
}