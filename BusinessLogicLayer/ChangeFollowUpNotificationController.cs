using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class ChangeFollowUpNotificationController : IChangeFollowUpNotificationDatabaseManager
    {
        private IChangeFollowUpNotificationDatabaseManager changeFollowUpNotificationDatabaseManager;
        public ChangeFollowUpNotificationController()
        {
            changeFollowUpNotificationDatabaseManager = new ChangeFollowUpNotificationDatabaseManager("");
        }
        public void ChangeFollowUpNotification(ChangeNotificationsDomain changeNotificationsDomain)
        {
            changeFollowUpNotificationDatabaseManager.ChangeFollowUpNotification(changeNotificationsDomain);
        }
    }
}
