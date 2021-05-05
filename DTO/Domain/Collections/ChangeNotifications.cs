using System;

namespace DataClasses.Domain.Collections
{
    public class ChangeNotifications : SessionInfo
    {
        public int CollectionID { get; set; }
        public TimeSpan NotificationTimeInterval { get; set; }
    }
}