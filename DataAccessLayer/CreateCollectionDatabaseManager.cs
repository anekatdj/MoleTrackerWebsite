using APIWebServiesConnector;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataAccessLayer
{
    public class CreateCollectionDatabaseManager : ICreateCollectionDatabaseManager
    {
        private IAPIService API;

        public CreateCollectionDatabaseManager()
        {
            API = new StubApiService();
        }

        public void AddNewCollection(CollectionDomain collection)
        {
            CollectionDTO collectionDTO = collection.ToDTO(collection.Location.BodyParts);
            try
            {
                string result = API.PostObject<CollectionDTO>("NewCollection", collectionDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveNewCollection(CollectionDomain collection)
        {
            CollectionDTO collectionDTO = collection.ToDTO(collection.Location.BodyParts);
            try
            {
                API.PostObject<CollectionDTO>("PostNewCollection", collectionDTO);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
