using System;

namespace DataClasses.CollectionDTO
{
    public class ChangeNotificationsDTO
    {
        public int CollectionID { get; set; }
        public TimeSpan NotificationTimeInterval { get; set; }
    }
}
