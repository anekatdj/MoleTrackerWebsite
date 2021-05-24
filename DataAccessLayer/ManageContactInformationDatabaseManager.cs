using System;
using System.Collections.Generic;
using System.Text;
using APIWebServiesConnector;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using DataClasses.DTO;

namespace DataAccessLayer
{
    public class ManageContactInformationDatabaseManager : IManageContactInformationDatabaseManager
    {

        private ChangeNotificationsDTO changeNotificationsDTO;
        private DoctorContactInfoRequestDTO doctorContactInfoRequestDTO;
        public IAPIService API { get; set; }

        public ManageContactInformationDatabaseManager(string stub)
        {
            API = APIFactory.GetAPI(stub);
        }

        public void ChangeFollowUpNotification(ChangeNotificationsDomain changeNotificationsDomain)
        {
            changeNotificationsDTO = changeNotificationsDomain.ToDTO();
            try
            {
                var result =
                    API.PostObject<ChangeNotificationsDTO>("ChangeNotificationInterval", changeNotificationsDTO);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public DoctorInfoDomain GetDoctorInfo(DoctorContactInfoRequestDTO doctorContactInfoRequestDTO)
        {
            
            throw new NotImplementedException();
        }
    }
}