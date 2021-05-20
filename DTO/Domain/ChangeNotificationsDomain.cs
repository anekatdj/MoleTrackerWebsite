using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class ChangeNotificationsDomain : SessionInfoDomain
    {
        public int CollectionID { get; set; }
        public TimeSpan NotificationTimeInterval { get; set; } //TODO Skal vi ikke lave tre (tisdpunkt, ugedag, antal uger mellem noti?)

        public string Hour { get; set; }
        public string WeekDay { get; set; }
        public string NumberOfWeeks { get; set; }
    }
}
