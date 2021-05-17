using DataClasses.Domain.Collections;
using DataClasses.DTO;

namespace PW_DataAccessLayer.Interfaces
{
    public interface ICreateNewCollectionDatabaseManager
    {
        CollectionDTO CollectionDTO { get; set; }
        void GetExistingCollection(Collection collection);
        void PostNewCollection(Collection collection);
    }
}