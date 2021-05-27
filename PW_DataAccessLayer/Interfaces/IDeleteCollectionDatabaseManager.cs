using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IDeleteCollectionDatabaseManager
    {
        public void DeleteCollection(Collection collection, PatientInfo patientInfo);
    }
}