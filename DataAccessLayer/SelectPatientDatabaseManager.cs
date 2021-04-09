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
        private PatientInfoRequestDTO patientInfoRequestDTO;
        private PatientDataDomain patientDataDomain;
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
            patientDataDomain = new PatientDataDomain()
            {
                PatientID = patientDataDTO.PatientID,
                CollectionList = patientDataDTO.CollectionList
            };
            return patientDataDomain;
        }
        //public PatientInfoDomain GetPatientInfo()
        //{
        //    PatientInfoDTO patientInfoDTO = new PatientInfoDTO();

        //}
    }
}
