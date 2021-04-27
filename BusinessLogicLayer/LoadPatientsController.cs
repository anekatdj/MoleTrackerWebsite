using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class LoadPatientsController : ILoadPatients
    {
        private ILoadPatientsDatabaseManager loadPatientsDatabase;

        public LoadPatientsController()
        {
            loadPatientsDatabase = new LoadPatientsDatabaseManager();
        }
        public MedicalPracticePatientsDomain LoadPatientList(DoctorInfoDomain doctorInfoDomain)
        {
            return loadPatientsDatabase.GetMedicalPracticePatients(doctorInfoDomain);
        }



    }
}
