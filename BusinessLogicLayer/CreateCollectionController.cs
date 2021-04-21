﻿using BusinessLogicLayer.BusinessLogicLayerInterfaces;
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
            createCollectionDatabaseManager = new CreateCollectionDatabaseManager();
        }
        public void AddNewCollection()
        {
            throw new NotImplementedException();
        }

        public void SaveNewCollection(CollectionDomain collection)
        {
            createCollectionDatabaseManager.SaveNewCollection(collection);
        }
    }
}