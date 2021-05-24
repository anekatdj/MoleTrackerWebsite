using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class MarkCollectionController : IMarkCollectionController
    {
        private MarkCollectionDatabaseManager _markCollectionDatabaseManager;

        public MarkCollectionController()
        {
            _markCollectionDatabaseManager = new MarkCollectionDatabaseManager("");
        }
        public void HandleMarking(ChangeCollectionMarkingDomain _changeCollectionMarking)
        {
            _markCollectionDatabaseManager.PostMarkedCollection(_changeCollectionMarking);
        }
    }
}
