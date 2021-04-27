using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataAccessLayer;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class SelectPatientController : ISelectPatientController
    {
        public ISelectPatientDatabaseManager SelectPatientDatabaseManager { get; set; }

        public PatientInfoDomain SelectedPatient { get; set; }
        public SelectPatientController()
        {
            SelectPatientDatabaseManager = new SelectPatientDatabaseManager();
            
            SelectedPatient = new PatientInfoDomain();
        }
        public PatientDataDomain GetPatientData(PatientInfoDomain patientInfoDomain)
        {
            return SelectPatientDatabaseManager.GetPatientData(patientInfoDomain);
        }
        public void GetPatientInfo(PatientInfoDomain patientInfo)
        {
            SelectPatientDatabaseManager.GetPatientInfo(patientInfo);
        }

    }
}
