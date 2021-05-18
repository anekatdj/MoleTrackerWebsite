using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class ChangeNotificationsDomain
    {
        public int CollectionID { get; set; }
        public string NotificationTimeInterval { get; set; }
        //TODO Outcomment
        public ChangeNotificationsDTO ToDTO()
        {
            ChangeNotificationsDTO changeNotifications = new ChangeNotificationsDTO()
            {
                CollectionID = CollectionID,
                //NotificationTimeInterval = NotificationTimeInterval
            };
            return changeNotifications;
        }
    }
}
