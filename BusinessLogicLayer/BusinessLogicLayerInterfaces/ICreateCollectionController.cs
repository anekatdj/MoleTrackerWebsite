using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ICreateCollectionController
    {
        void AddNewCollection();
        void SaveNewCollection(CollectionDomain collection);
    }
}
