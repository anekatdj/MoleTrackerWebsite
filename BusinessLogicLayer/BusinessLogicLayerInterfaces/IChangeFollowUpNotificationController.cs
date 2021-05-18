using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface IChangeFollowUpNotificationController
    {
        void ChangeFollowUpNotification(ChangeNotificationsDomain changeNotificationsDomain);
    }
}
