using DataClasses.Domain.Collections;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IChangeCollectionNameDatabaseManager
    {
        public void PostChangedCollectionName(ChangeCollectionName _changeCollectionName);
    }
}