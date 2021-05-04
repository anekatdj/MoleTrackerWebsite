using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ISelectPatientController
    {
        ISelectPatientDatabaseManager SelectPatientDatabaseManager { get; set; }
        PatientInfoDomain SelectedPatient { get; set; }
        string DateOfBirth { get; set; }

        public bool BirthDataCalcFailed { get; set; }
        PatientDataDomain GetPatientData(PatientInfoDomain patientInfoDomain);

        void HandlePatientInfo();
    }
}
