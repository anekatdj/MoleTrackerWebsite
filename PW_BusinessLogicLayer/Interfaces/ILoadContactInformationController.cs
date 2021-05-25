using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ILoadContactInformationController
    {
        public DoctorContactInfo HandleDoctorContactInfo(PatientInfo patientInfo);
    }
}