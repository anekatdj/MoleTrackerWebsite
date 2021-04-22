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
        private IAPIService API;
        public MedicalPracticePatientsDTO medicalPracticePatientsDTO;

        public LoadPatientsDatabaseManager()
        {
            API = APIFactory.GetAPI("");

        }

        public MedicalPracticePatientsDomain GetMedicalPracticePatients(DoctorInfoDomain doctorInfoDomain)
        {
            //MedicalPracticePatientsDTO medicalPracticePatientsDTO = new MedicalPracticePatientsDTO();
            DoctorInfoDTO doctorInfoDTOTest = doctorInfoDomain.ToDTO();
            //DoctorInfoDTO doctorInfoDTO = new DoctorInfoDTO() {DoctorID = doctorInfoDomain.DoctorID};
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
