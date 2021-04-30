using System;
using APIWebServiesConnector;
using DataClasses.Domain;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class CreateNewCollectionDatabaseManager : ICreateNewCollectionDatabaseManager
    {

        private CollectionDTO collectionDTO;

        private PatientInfoDTO patientInfoDTO;

        private Collection collection;


        private IAPIService API;

        public CreateNewCollectionDatabaseManager()
        {
            //API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());

            API = new StubApiService();
        }

        public Collection GetCollection()
        {
            try
            {
                collectionDTO = API.GetObject<CollectionDTO, PatientInfoDTO>("CollectionRequest", collectionDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            collection.CollectionID = collectionDTO.CollectionID;
            collection.CollectionName = collectionDTO.CollectionName;
            //foreach (var picture in collectionDTO.PictureList)
            //{
            //    collection.PictureList.Add(picture);
            //}

            //collection.Location = collectionDTO.Location;

            return collection;
        }
    }
}