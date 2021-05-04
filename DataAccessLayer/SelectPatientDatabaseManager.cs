using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using APIWebServiesConnector.APIStringFabrics;
using DataClasses.Domain;
using DataClasses.DTO;
using DataClasses.DTO.MISCDTOS;
using PatientDataDTO = DataClasses.DTO.MISCDTOS.PatientDataDTO;

namespace DataAccessLayer
{
    public class SelectPatientDatabaseManager : ISelectPatientDatabaseManager
    {
        private IAPIService API;

        public SelectPatientDatabaseManager()
        {
            API = APIFactory.GetAPI("");

        }

        public PatientDataDomain GetPatientData(PatientInfoDomain patientInfoDomain)
        {
            PatientDataDTO patientDataDTO = new PatientDataDTO();
            PatientInfoRequestDTO patientInfoRequestDTO = new PatientInfoRequestDTO() { PatientID = patientInfoDomain.PatientID };
            try
            {
                patientDataDTO = API.GetObject<PatientDataDTO, PatientInfoRequestDTO>("GetPatientData", patientInfoRequestDTO);
            }
            catch (Exception e)
            {
                
                throw e /*new Exception("API Fejl")*/;
            }

            PatientDataDomain patientDataDomain = DTOConverter.PatientDataToDomain(patientDataDTO);

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
            catch (Exception e)
            {

                throw e;
            }

            PatientInfoDomain newpatientInfoDomain = DTOConverter.PatientInfoToDomain(patientInfoDTO);

            

            return newpatientInfoDomain;
        }
    }
}
