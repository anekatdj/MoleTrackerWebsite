using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;

namespace PW_DataAccessLayer.Interfaces
{
    public interface ILoadContactInfoDatabaseManager
    {
        public DoctorContactInfo GetContactInfo(PatientInfo patientInfo);
    }
}