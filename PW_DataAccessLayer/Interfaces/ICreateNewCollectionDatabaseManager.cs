using DataClasses.Domain.Collections;
using DataClasses.DTO;

namespace PW_DataAccessLayer.Interfaces
{
    public interface ICreateNewCollectionDatabaseManager
    {
        public void GetExistingCollection(Collection collection);
        public void PostNewCollection(Collection collection);
    }
}