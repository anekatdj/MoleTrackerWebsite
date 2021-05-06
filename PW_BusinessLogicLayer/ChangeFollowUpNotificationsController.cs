using DataClasses.Domain.Collections;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class ChangeFollowUpNotificationsController : IChangeFollowUpNotificationsController
    {
        private IChangeNotificationsDatabaseManager _changeNotificationsDatabaseManager;

        public ChangeFollowUpNotificationsController()
        {
            _changeNotificationsDatabaseManager = new ChangeNotificationsDatabaseManager();
        }

        public void HandleChangedNotifications(ChangeNotifications changeNotifications)
        {
            _changeNotificationsDatabaseManager.PostChangedNotifications(changeNotifications);
        }
    }
}