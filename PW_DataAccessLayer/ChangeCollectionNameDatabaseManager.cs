using System;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Collections;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class ChangeCollectionNameDatabaseManager : IChangeCollectionNameDatabaseManager
    {
        private readonly IAPIService API;

        public ChangeCollectionNameDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);
        }

        public void PostChangedCollectionName(Collection collection)
        {
            ChangeCollectionNameDTO _changeCollectionNameDTO = new ChangeCollectionNameDTO();

            _changeCollectionNameDTO.CollectionID = collection.CollectionID;
            _changeCollectionNameDTO.CollectionName = collection.CollectionName;

            //TODO lav try-catch ordentligt
            API.PostObject<ChangeCollectionNameDTO>("ChangeCollectionName", _changeCollectionNameDTO);
        }
    }
}