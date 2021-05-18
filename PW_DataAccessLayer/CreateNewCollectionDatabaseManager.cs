using System;
using System.Collections.Generic;
using System.Linq;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Collections;
using DataClasses.Domain.MISC;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class CreateNewCollectionDatabaseManager : ICreateNewCollectionDatabaseManager
    {
        public  CollectionDTO CollectionDTO { get; set; }
        public PatientData CurrentPatientData { get; set; }

        private IAPIService API;

        public CreateNewCollectionDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);
            CollectionDTO = new CollectionDTO();
        }

        public int PostNewCollection(Collection collection)
        {
            CollectionDTO collectionDTO = collection.ToDTO(collection.Location.BodyParts);
            collectionDTO.Location.BodyPartSide = "";
            try
            {
                string ID = API.PostObject<CollectionDTO>("NewCollection", collectionDTO);
                collection.CollectionID = Convert.ToInt32(ID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return collection.CollectionID;
        }

        //TODO til mark collection
        public void UpdateCollection(Collection UpdatedCollection)
        {
            Collection OldCollectionDTO = CurrentPatientData.CollectionList.First(
                i => i.CollectionID == UpdatedCollection.CollectionID);

            int indexPosition = CurrentPatientData.CollectionList.IndexOf(OldCollectionDTO);

            CurrentPatientData.CollectionList[indexPosition] = UpdatedCollection;
        }


        //public void GetExistingCollection(Collection collection)
        //{
        //    CollectionRequestDTO collectionRequestDTO = new CollectionRequestDTO();

        //    collectionRequestDTO.CollectionID = collection.CollectionID;

        //    collectionRequestDTO.PatientID = CurrentPatientInfo.PatientID;

        //    try
        //    {
        //        CollectionDTO = API.GetObject<CollectionDTO, CollectionRequestDTO>("GetCollection", collectionRequestDTO);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    collection.CollectionID = CollectionDTO.CollectionID;
        //    collection.CollectionName = CollectionDTO.CollectionName;
        //    //collection.Location = CollectionDTO.Location;
        //    //collection.PictureList = CollectionDTO.PictureList;
        //    ////foreach (var picture in collectionDTO.PictureList)
        //    ////{
        //    ////    collection.PictureList.Add(picture);
        //    ////}

        //    ////collection.Location = collectionDTO.Location;

        //    //return collection;
        //}
    }
}