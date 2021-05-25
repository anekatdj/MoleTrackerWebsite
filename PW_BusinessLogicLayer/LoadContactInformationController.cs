using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class LoadContactInformationController : ILoadContactInformationController
    {
        private ILoadContactInfoDatabaseManager _loadContactInfoDatabaseManager;

        public LoadContactInformationController()
        {
            _loadContactInfoDatabaseManager = new LoadContactInfoDatabaseManager("");
        }

        public DoctorContactInfo HandleDoctorContactInfo(PatientInfo patientInfo)
        {
            return _loadContactInfoDatabaseManager.GetContactInfo(patientInfo);
        }

    }
}