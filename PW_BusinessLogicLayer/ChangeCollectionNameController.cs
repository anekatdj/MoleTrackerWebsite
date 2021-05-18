using DataClasses.Domain.Collections;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class ChangeCollectionNameController : IChangeCollectionNameController
    {
        private IChangeCollectionNameDatabaseManager _changeCollectionNameDatabaseManager;

        public ChangeCollectionNameController()
        {
            _changeCollectionNameDatabaseManager = new ChangeCollectionNameDatabaseManager("");
        }

        public void HandleChangedName(Collection collection)
        {
            _changeCollectionNameDatabaseManager.PostChangedCollectionName(collection);
        }
    }
}