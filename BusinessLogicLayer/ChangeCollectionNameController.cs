using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class ChangeCollectionNameController : IChangeCollectionNameController
    {
        private IChangeCollectionNameDatabaseManager changeCollectionNameDatabaseManager;
        public ChangeCollectionNameController()
        {
            changeCollectionNameDatabaseManager = new ChangeCollectionNameDatabaseManager("");
        }
        public void HandleChangedName(CollectionDomain collectionInfo)
        {
            changeCollectionNameDatabaseManager.PostChangedCollectionName(collectionInfo);
        }
    }
}
