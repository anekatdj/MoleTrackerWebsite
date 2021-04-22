using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;

namespace DataAccessLayer.DataAccessLayerInterfaces
{
    public interface ILogInDatabaseManager
    {
        DoctorInfoDomain VerifyLoginWithAPI(LoginInfoDomain loginInfo);
    }
}
