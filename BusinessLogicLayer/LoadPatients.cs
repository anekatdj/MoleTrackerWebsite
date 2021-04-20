using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using DataClasses.LoginDTO;
using DataClasses.MISCDTO;

namespace BusinessLogicLayer
{
    public class LoadPatients : ILoadPatients
    {
        private ILoadPatientsDatabaseManager loadPatientsDatabase;

        public LoadPatients()
        {
            loadPatientsDatabase = new LoadPatientsDatabaseManager();
        }
        public void LoadPatientList(MedicalPracticePatientsDomain patients)
        {
            loadPatientsDatabase.GetMedicalPracticePatients(/*Skal ændres senere*/new DoctorInfoDomain());
        }



    }
}
