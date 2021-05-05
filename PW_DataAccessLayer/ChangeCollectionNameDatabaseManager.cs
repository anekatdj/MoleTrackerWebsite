using System;
using APIWebServiesConnector;
using DataClasses.Domain.Collections;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class ChangeCollectionNameDatabaseManager : IChangeCollectionNameDatabaseManager
    {
        private IAPIService API;

        public ChangeCollectionNameDatabaseManager()
        {
            //API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());

            API = new StubApiService();
        }

        public void PostChangedCollectionName(ChangeCollectionName _changeCollectionName) //TODO Skal det her være void?
        {
            ChangeCollectionNameDTO _changeCollectionNameDTO = new ChangeCollectionNameDTO();

            _changeCollectionNameDTO.CollectionID = _changeCollectionName.CollectionID;
            _changeCollectionNameDTO.CollectionName = _changeCollectionName.CollectionName;

            try
            {
                string ID = API.PostObject<ChangeCollectionMarkingDTO>("PutNewCollectionName", _changeCollectionNameDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}