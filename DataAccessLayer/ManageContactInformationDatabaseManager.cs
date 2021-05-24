using System;
using System.Collections.Generic;
using System.Text;
using APIWebServiesConnector;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using DataClasses.DTO;

namespace DataAccessLayer
{
    public class ManageContactInformationDatabaseManager : IManageContactInformationDatabaseManager
    {

        private DoctorContactInfoDomain doctorContactInfoDomain;
        private DoctorContactInfoDTO doctorContactInfoDTO;
        private DoctorContactInfoRequestDTO doctorContactInfoRequestDTO;
        public IAPIService API { get; set; }

        public ManageContactInformationDatabaseManager(string stub)
        {
            API = APIFactory.GetAPI(stub);
        }

        public DoctorContactInfoDomain GetDoctorInfo(DoctorContactInfoRequestDomain doctorContactInfoRequestDomain)
        {
            doctorContactInfoRequestDTO = doctorContactInfoRequestDomain.ToDTO();
            try
            {
                doctorContactInfoDTO = API.GetObject<DoctorContactInfoDTO, DoctorContactInfoRequestDTO>("GetMedicalPracticeContactInfo", doctorContactInfoRequestDTO);
            }
            catch (Exception e)
            {
                throw;
            }

            doctorContactInfoDomain = DTOConverter.DoctorContactInfoToDomain(doctorContactInfoDTO);
            return doctorContactInfoDomain;
        }
    }
}