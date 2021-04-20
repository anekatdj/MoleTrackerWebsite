using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataAccessLayer;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class SelectPatient : ISelectPatient
    {
        private ISelectPatientDatabaseManager selectPatientDatabaseManager;

        public PatientInfoDomain SelectedPatient { get; set; }
        public SelectPatient()
        {
            selectPatientDatabaseManager = new SelectPatientDatabaseManager();
            
            SelectedPatient = new PatientInfoDomain();
        }
        public PatientDataDomain GetPatientData(PatientInfoDomain patientInfoDomain)
        {
            return selectPatientDatabaseManager.GetPatientData(patientInfoDomain);
        }
        public void GetPatientInfo(PatientInfoDomain patientInfo)
        {
            selectPatientDatabaseManager.GetPatientInfo(patientInfo);
        }

    }
}
