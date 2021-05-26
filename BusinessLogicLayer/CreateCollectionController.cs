using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class CreateCollectionController : ICreateCollectionController
    {
        private ICreateCollectionDatabaseManager createCollectionDatabaseManager;
        public CreateCollectionController()
        {
            createCollectionDatabaseManager = new CreateCollectionDatabaseManager("");
        }
        public void AddNewCollection(CollectionDomain collection)
        {
            createCollectionDatabaseManager.AddNewCollection(collection);
        }
    }
}
