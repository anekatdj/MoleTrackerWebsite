using DataClasses.Domain.Collections;
using DataClasses.Domain.MISC;
using DataClasses.DTO;

namespace PW_DataAccessLayer.Interfaces
{
    public interface ICreateNewCollectionDatabaseManager
    {
        public PatientData CurrentPatientData { get; set; }
        CollectionDTO CollectionDTO { get; set; }
        int PostNewCollection(Collection collection);
    }
}