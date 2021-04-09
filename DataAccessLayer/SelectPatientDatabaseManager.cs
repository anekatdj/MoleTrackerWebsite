using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using DataClasses.MISCDTO;
using DataClasses.Domain;

namespace DataAccessLayer
{
    public class SelectPatientDatabaseManager : ISelectPatientDatabaseManager
    {
        private PatientInfoRequestDTO patientInfoRequestDTO;
        private PatientData patientData;
        private IAPIService API;

        public SelectPatientDatabaseManager()
        {
            API = new StubApiService();
        }

        public PatientData GetPatientDate(PatientInfoRequestDTO patientInfoRequestDTO)
        {
            PatientDataDTO patientDataDTO = new PatientDataDTO();
            
            try
            {
                patientDataDTO = API.GetObject<PatientDataDTO, PatientInfoRequestDTO>("GetPatientData", patientInfoRequestDTO);
            }
            catch (Exception)
            {

                throw;
            }
            patientData = new PatientData()
            {
                PatientID = patientDataDTO.PatientID,
                CollectionList = patientDataDTO.CollectionList
            };
            return patientData;
        }
    }
}
