using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class LoadContactInfoDatabaseManager : ILoadContactInfoDatabaseManager
    {
        private IAPIService API;

        public LoadContactInfoDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);
        }

        public DoctorContactInfo GetContactInfo(PatientInfo patientInfo)
        {
            DoctorContactInfoRequestDTO _doctorContactInfoRequestDTO = new DoctorContactInfoRequestDTO();
            DoctorContactInfoDTO _doctorInfoDTO = new DoctorContactInfoDTO();
            DoctorContactInfo _doctorInfo = new DoctorContactInfo();

            _doctorContactInfoRequestDTO.DoctorContactID = patientInfo.MedicalPracticeID;

            _doctorInfoDTO = API.GetObject<DoctorContactInfoDTO, DoctorContactInfoRequestDTO>("GetMedicalPracticeContactInfo", _doctorContactInfoRequestDTO);
            _doctorInfo = DTOConverter.DoctorContactInfoToDomain(_doctorInfoDTO);
            //hej ak
            return _doctorInfo;
        }
    }
}