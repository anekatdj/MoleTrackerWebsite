using DataClasses.Domain.Collections;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IChangeNotificationsDatabaseManager
    {
        public void PostChangedNotifications(ChangeNotifications _changeNotifications);
    }
}