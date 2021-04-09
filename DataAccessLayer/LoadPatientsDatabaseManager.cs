using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using DTO.MISCDTO;
using DTO.LoginDTO;

namespace DataAccessLayer
{
    public class LoadPatientsDatabaseManager : ILoadPatientsDatabaseManager
    {
        private MedicalPracticePatientsDTO medicalPracticePatients;
        private IAPIService API;

        public LoadPatientsDatabaseManager()
        {
            API = new StubApiService();
        }

        public MedicalPracticePatients GetMedicalPracticePatients()
        {
            DoctorInfoDTO doctorInfoDTO = new DoctorInfoDTO();
            try
            {
                medicalPracticePatients = API.GetObject<MedicalPracticePatientsDTO, DoctorInfoDTO>("GetMedicalPracticePatients", doctorInfoDTO);
            }
            catch (Exception)
            {

                throw;
            }
            return medicalPracticePatients;
        }
    }
}
