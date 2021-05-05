using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;

namespace PW_BusinessLogicLayer
{
    public class MarkCollectionController : IMarkCollectionController
    {
        private MarkCollectionDatabaseManager _markCollectionDatabaseManager;
        public void HandleMarking()
        {
            _markCollectionDatabaseManager.PostMarkedCollection()
        }
    }
}