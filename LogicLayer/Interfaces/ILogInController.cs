

using System.Diagnostics;
using DataClasses.Domain;

namespace LogicLayer.Interfaces
{
    public interface ILogInController
    {
        bool HandleLogin(LogInInfo loginInfo);
    }
}