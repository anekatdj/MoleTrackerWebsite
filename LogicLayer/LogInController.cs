using System;
using DataClasses.Domain;
using LogicLayer.Interfaces;

namespace LogicLayer
{
    public class LogInController : ILogInController
    {
        public bool HandleLogin(LogInInfo loginInfo)
        {
            return true;
            //{
            //    if (loginInfo.Username == "121212-1212" && loginInfo.Password == "kodeord")
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
        }
    }
}
