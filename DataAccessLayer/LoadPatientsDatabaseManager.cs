using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using DataClasses.Domain;
using DataClasses.LoginDTO;
using DataClasses.MISCDTO;
using SessionInfoDTO = DataClasses.DataObjects.DTO.SessionInfoDTO;

namespace DataAccessLayer
{
    public class LoadPatientsDatabaseManager : ILoadPatientsDatabaseManager
    {
        private IAPIService API;

        public LoadPatientsDatabaseManager()
        {
            API = new StubApiService();
        }

        public MedicalPracticePatientsDomain GetMedicalPracticePatients(DoctorInfoDomain doctorInfoDomain)
        {
            MedicalPracticePatientsDTO medicalPracticePatientsDTO = new MedicalPracticePatientsDTO();
            DoctorInfoDTO doctorInfoDTO = doctorInfoDomain.ToDTO();
            try
            {
                medicalPracticePatientsDTO = API.GetObject<MedicalPracticePatientsDTO, DoctorInfoDTO>("GetMedicalPracticePatients", doctorInfoDTO);
            }
            catch (Exception)
            {

                throw;
            }

            MedicalPracticePatientsDomain medicalPracticePatientsDomain = medicalPracticePatientsDTO.ToDomain();
            return medicalPracticePatientsDomain;
        }
    }
}
