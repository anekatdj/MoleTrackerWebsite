using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using DataClasses.MISCDTO;
using DataClasses.Domain;
using DataClasses.LoginDTO;

namespace DataAccessLayer
{
    public class SelectPatientDatabaseManager : ISelectPatientDatabaseManager
    {
        private IAPIService API;

        public SelectPatientDatabaseManager()
        {
            API = new StubApiService();
        }

        public PatientDataDomain GetPatientData(PatientInfoDomain patientInfoDomain)
        {
            PatientDataDTO patientDataDTO = new PatientDataDTO();
            PatientInfoRequestDTO patientInfoRequestDTO = new PatientInfoRequestDTO() { PatientID = patientInfoDomain.PatientID };
            try
            {
                patientDataDTO = API.GetObject<PatientDataDTO, PatientInfoRequestDTO>("GetPatientData", patientInfoRequestDTO);
            }
            catch (Exception)
            {

                throw;
            }

            PatientDataDomain patientDataDomain = patientDataDTO.ToDomain();

            return patientDataDomain;
        }
        public PatientInfoDomain GetPatientInfo(PatientInfoDomain patientInfoDomain)
        {
            PatientInfoDTO patientInfoDTO = new PatientInfoDTO();
            PatientInfoRequestDTO patientInfoRequestDTO = new PatientInfoRequestDTO() { PatientID = patientInfoDomain.PatientID };
            try
            {
                patientInfoDTO = API.GetObject<PatientInfoDTO, PatientInfoRequestDTO>("GetPatientInfo", patientInfoRequestDTO);
            }
            catch (Exception)
            {

                throw;
            }

            PatientInfoDomain newpatientInfoDomain = patientInfoDTO.ToDomain();

            

            return newpatientInfoDomain;
        }
    }
}
