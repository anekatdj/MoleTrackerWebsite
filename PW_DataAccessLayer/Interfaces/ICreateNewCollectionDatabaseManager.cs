using DataClasses.Domain.Collections;

namespace PW_DataAccessLayer.Interfaces
{
    public interface ICreateNewCollectionDatabaseManager
    {
        public void GetExistingCollection(Collection collection);
    }
}