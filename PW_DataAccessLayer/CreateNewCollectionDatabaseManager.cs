using System;
using APIWebServiesConnector;
using DataClasses.Domain.Collections;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class CreateNewCollectionDatabaseManager : ICreateNewCollectionDatabaseManager
    {

        public  CollectionDTO CollectionDTO { get; private set; }
        public PatientInfoDTO CurrentPatient { get; set; }

        private IAPIService API;

        public CreateNewCollectionDatabaseManager()
        {
            API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());
            //API = new StubApiService();
            CurrentPatient = new PatientInfoDTO();
            CollectionDTO = new CollectionDTO();
        }

        //public Collection PostNewCollection()
        //{

        //}

        public void GetExistingCollection(Collection collection)
        {
            CollectionRequestDTO collectionRequestDTO = new CollectionRequestDTO();

            collectionRequestDTO.CollectionID = collection.CollectionID;

            collectionRequestDTO.PatientID = CurrentPatient.PatientID;

            try
            {
                CollectionDTO = API.GetObject<CollectionDTO, CollectionRequestDTO>("GetCollection", collectionRequestDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            collection.CollectionID = CollectionDTO.CollectionID;
            collection.CollectionName = CollectionDTO.CollectionName;
            //collection.Location = CollectionDTO.Location;
            //collection.PictureList = CollectionDTO.PictureList;
            ////foreach (var picture in collectionDTO.PictureList)
            ////{
            ////    collection.PictureList.Add(picture);
            ////}

            ////collection.Location = collectionDTO.Location;

            //return collection;
        }
    }
}