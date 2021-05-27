using System;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Collections;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class MarkCollectionDatabaseManager : IMarkCollectionDatabaseManager
    {
        private IAPIService API;

        public MarkCollectionDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);
        }

        public void PostMarkedCollection(ChangeCollectionMarking _changeCollectionMarking)
        {
            ChangeCollectionMarkingDTO _changeCollectionMarkingDTO = new ChangeCollectionMarkingDTO();

            _changeCollectionMarkingDTO.CollectionID = _changeCollectionMarking.CollectionID;
            _changeCollectionMarkingDTO.IsMarked = _changeCollectionMarking.IsMarked;

            API.PostObject<ChangeCollectionMarkingDTO>("ChangeCollectionMarking", _changeCollectionMarkingDTO);
        }
    }
}