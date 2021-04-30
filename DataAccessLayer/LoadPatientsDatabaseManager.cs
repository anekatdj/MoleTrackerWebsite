using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using APIWebServiesConnector.APIStringFabrics;
using DataClasses.Domain;
using DataClasses.DTO;
using SessionInfoDTO = DataClasses.DataObjects.DTO.SessionInfoDTO;

namespace DataAccessLayer
{
    public class LoadPatientsDatabaseManager : ILoadPatientsDatabaseManager
    {

        public IAPIService API { get; set; }
        public MedicalPracticePatientsDTO medicalPracticePatientsDTO;

        public LoadPatientsDatabaseManager(string stub)
        {
            API = APIFactory.GetAPI(stub);

        }

        public MedicalPracticePatientsDomain GetMedicalPracticePatients()
        {
            
            try
            {
                medicalPracticePatientsDTO = API.GetObject<MedicalPracticePatientsDTO, SessionInfoDTO>("MedicalPracticePatients", new SessionInfoDTO());
            }
            catch (Exception e)
            {

                throw e;
            }

            MedicalPracticePatientsDomain medicalPracticePatientsDomain = DTOConverter.MedicalPracticePatientsToDomain(medicalPracticePatientsDTO);
            return medicalPracticePatientsDomain;
        }
    }
}
