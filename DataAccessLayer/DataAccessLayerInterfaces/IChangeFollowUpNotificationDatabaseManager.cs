using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;
using DataClasses.DTO;

namespace DataAccessLayer.DataAccessLayerInterfaces
{
    public interface IChangeFollowUpNotificationDatabaseManager
    {
        void ChangeFollowUpNotification(ChangeNotificationsDomain changeNotificationsDomain);
    }
}
