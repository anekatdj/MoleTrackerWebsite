using DataClasses.Domain.Collections;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IMarkCollectionDatabaseManager
    {
        public void PostMarkedCollection(ChangeCollectionMarking _changeCollectionMarking);
    }
}