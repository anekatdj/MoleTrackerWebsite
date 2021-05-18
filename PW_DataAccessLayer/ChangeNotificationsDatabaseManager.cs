using System;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Collections;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class ChangeNotificationsDatabaseManager : IChangeNotificationsDatabaseManager
    {
        private IAPIService API;

        public ChangeNotificationsDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);
        }

        public void PostChangedNotifications(ChangeNotifications _changeNotifications) //TODO Skal det her være void?
        {
            //ChangeNotificationsDTO _changeNotificationsDTO = new ChangeNotificationsDTO();

            //_changeNotificationsDTO.CollectionID = _changeNotifications.CollectionID;
            //_changeNotificationsDTO.NotificationTimeInterval = _changeNotifications.NotificationTimeInterval;

            //try
            //{
            //    string ID = API.PostObject<ChangeCollectionMarkingDTO>("PutNewCollectionNotification", _changeNotificationsDTO);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
        }
    }
}