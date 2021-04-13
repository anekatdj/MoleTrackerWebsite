using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using DataClasses.Domain;
using DataClasses.LoginDTO;
using DataClasses.MISCDTO;

namespace DataAccessLayer
{
    public class LoadPatientsDatabaseManager : ILoadPatientsDatabaseManager
    {
        private MedicalPracticePatientsDomain medicalPracticePatientsDomain;
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

            medicalPracticePatientsDomain = medicalPracticePatientsDTO.ToDomain();
            return medicalPracticePatientsDomain;
        }
    }
}
