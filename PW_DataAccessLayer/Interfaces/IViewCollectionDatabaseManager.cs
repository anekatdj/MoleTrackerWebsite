using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IViewCollectionDatabaseManager
    {
        Collection GetCollection();
        public PatientData GetPatientData(PatientInfo patientInfoDomain);
    }
}