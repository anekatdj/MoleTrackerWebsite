using System;
using System.Collections.Generic;
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

        public void PostNewCollection(Collection collection)
        {
            CollectionDTO collectionDTO = collection.ToDTO(collection.Location.BodyParts);

            try
            {
                string ID = API.PostObject<CollectionDTO>("NewCollection", collectionDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //collection.CollectionID = Convert.ToInt32(ID);
            //return collection.CollectionID;
        }


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