using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using APIWebServiesConnector;
using DataClasses.MISCDTO;
using DataClasses.LoginDTO;
using DataClasses.Domain;

namespace DataAccessLayer
{
    public class LoadPatientsDatabaseManager : ILoadPatientsDatabaseManager
    {
        private MedicalPracticePatientsDTO medicalPracticePatientsDTO;
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
                medicalPracticePatientsDTO = API.GetObject<MedicalPracticePatientsDTO, DoctorInfoDTO>("GetMedicalPracticePatients", doctorInfoDTO);
            }
            catch (Exception)
            {

                throw;
            }
            MedicalPracticePatients medicalPracticePatients = new MedicalPracticePatients()
            {
                MedicalPracticeID = medicalPracticePatientsDTO.MedicalPracticeID,
                PatientList = medicalPracticePatientsDTO.PatientList
            };
            return medicalPracticePatients;
        }
    }
}
