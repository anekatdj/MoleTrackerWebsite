using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class LoadPatientsController : ILoadPatientsController
    {
        public ILoadPatientsDatabaseManager LoadPatientsDatabaseManager { get; set; }

        public LoadPatientsController()
        {
            LoadPatientsDatabaseManager = new LoadPatientsDatabaseManager("");
        }
        public List<PatientInfoDomain> LoadPatientList()
        {
             MedicalPracticePatientsDomain medicalPractice = LoadPatientsDatabaseManager.GetMedicalPracticePatients();
             return medicalPractice.PatientList;
        }



    }
}
