using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataClasses.MISCDTO;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataAccessLayer;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class SelectPatient : ISelectPatient
    {
        private ISelectPatientDatabaseManager selectPatientDatabaseManager;
        public SelectPatient()
        {
            selectPatientDatabaseManager = new SelectPatientDatabaseManager();
        }
        public void GetPatientData(PatientInfoDomain patientInfoDomain)
        {
            selectPatientDatabaseManager.GetPatientData(patientInfoDomain);
        }
        public void GetPatientInfo(PatientInfoDomain patientInfo)
        {
            selectPatientDatabaseManager.GetPatientInfo(patientInfo);
        }
    }
}
