using APIWebServiesConnector;
using DataAccessLayer;
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

        public void GetContactInfo()
        {
            DoctorContactInfoRequestDTO _doctorContactInfoRequestDTO = new DoctorContactInfoRequestDTO();
            DoctorContactInfoDTO _doctorInfoDTO = new DoctorContactInfoDTO();
            _doctorInfoDTO = API.GetObject<DoctorContactInfoDTO, DoctorContactInfoRequestDTO>("GetMedicalPracticeContactInfo", _doctorContactInfoRequestDTO);
            DTOConverter.DoctorContactInfoToDomain(_doctorInfoDTO);
            //hej ak
        }
    }
}