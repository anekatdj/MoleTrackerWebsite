using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataAccessLayerInterfaces
{
    public interface ICreateCollectionDatabaseManager
    {
        void AddNewCollection(CollectionDomain collection);
    }
}
