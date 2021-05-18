using System;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class CreateNewCollectionController : ICreateNewCollectionController
    {
        private ICreateNewCollectionDatabaseManager _createNewCollectionDatabaseManager;

        public CreateNewCollectionController()
        {
            _createNewCollectionDatabaseManager = new CreateNewCollectionDatabaseManager();
        }

        public void HandleCreateNewCollection(Collection collection)
        {
            if (collection.CollectionName == "")
            {
                collection.CollectionName = "AutoNavn";
            }

            //collection.Location = new LocationOnBody();
            //collection.CollectionID = _createNewCollectionDatabaseManager.PostNewCollection(collection);
            _createNewCollectionDatabaseManager.PostNewCollection(collection);
        }

        //public void HandleLoadCollection(Collection collection)
        //{
        //    _createNewCollectionDatabaseManager.GetExistingCollection(collection);
        //}
    }
}