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
        public CollectionDTO CollectionDTO { get; set; }

        private readonly IAPIService API;

        public CreateNewCollectionDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);
            CollectionDTO = new CollectionDTO();
        }

        public void PostNewCollection(Collection collection)
        {
            CollectionDTO collectionDTO = collection.ToDTO(collection.Location.BodyParts);
            collectionDTO.Location.BodyPartSide = "";
            API.PostObject<CollectionDTO>("NewCollection", collectionDTO);
            collection = DTOConverter.CollectionToDomain(collectionDTO);
        }
    }
}