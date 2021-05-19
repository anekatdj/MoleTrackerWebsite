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

        private readonly IAPIService API;

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
    }
}