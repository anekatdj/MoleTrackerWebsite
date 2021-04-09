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
        private MedicalPracticePatientsDTO medicalPracticePatients;
        private IAPIService API;

        public LoadPatientsDatabaseManager()
        {
            API = new StubApiService();
        }

        public MedicalPracticePatientsDTO GetMedicalPracticePatients()
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
