using DataClasses.Domain.Collections;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class MarkCollectionController : IMarkCollectionController
    {
        private IMarkCollectionDatabaseManager _markCollectionDatabaseManager;

        public MarkCollectionController()
        {
            _markCollectionDatabaseManager = new MarkCollectionDatabaseManager("");
        }
        public void HandleMarking(ChangeCollectionMarking _changeCollectionMarking)
        {
            _markCollectionDatabaseManager.PostMarkedCollection(_changeCollectionMarking);
        }
    }
}