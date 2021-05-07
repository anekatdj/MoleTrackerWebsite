using System;
using DataClasses.Domain.Collections;
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
            _createNewCollectionDatabaseManager.GetExistingCollection(collection);
        }
    }
}