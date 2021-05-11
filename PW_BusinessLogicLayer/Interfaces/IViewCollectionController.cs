using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IViewCollectionController
    {
        public PatientData GetPatientData(PatientInfo patientInfoDomain);
    }
}