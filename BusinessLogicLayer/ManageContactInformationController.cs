using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class ManageContactInformationController : IManageContactInformationController
    {
        private IManageContactInformationDatabaseManager manageContactInformationDatabaseManager;
        public ManageContactInformationController()
        {
            manageContactInformationDatabaseManager = new ManageContactInformationDatabaseManager("");
        }
        public DoctorContactInfoDomain GetDoctorInfo(DoctorContactInfoRequestDomain doctorContactInfoRequestDomain)
        {
            return manageContactInformationDatabaseManager.GetDoctorInfo(doctorContactInfoRequestDomain);
        }
    }
}
