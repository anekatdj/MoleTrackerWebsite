using DataClasses.Domain.Collections;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IChangeFollowUpNotificationsController
    {
        public void HandleChangedNotifications(ChangeNotifications changeNotifications);
    }
}