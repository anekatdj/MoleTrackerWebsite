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
        private MedicalPracticePatients medicalPracticePatients;
        private IAPIService API;

        public LoadPatientsDatabaseManager()
        {
            API = new StubApiService();
        }

        public MedicalPracticePatients GetMedicalPracticePatients(DoctorInfoDTO doctorInfoDTO)
        {
            MedicalPracticePatientsDTO medicalPracticePatientsDTO = new MedicalPracticePatientsDTO();

            try
            {
                medicalPracticePatientsDTO = API.GetObject<MedicalPracticePatientsDTO, DoctorInfoDTO>("GetMedicalPracticePatients", doctorInfoDTO);
            }
            catch (Exception)
            {

                throw;
            }
            medicalPracticePatients = new MedicalPracticePatients()
            {
                MedicalPracticeID = medicalPracticePatientsDTO.MedicalPracticeID,
                PatientList = medicalPracticePatientsDTO.PatientList
            };
            return medicalPracticePatients;
        }
    }
}
