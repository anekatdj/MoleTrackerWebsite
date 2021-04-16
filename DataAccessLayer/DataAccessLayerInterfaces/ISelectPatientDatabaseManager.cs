using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataAccessLayerInterfaces
{
    public interface ISelectPatientDatabaseManager
    {
        public PatientDataDomain GetPatientData(PatientInfoDomain patientInfoDomain);
        public PatientInfoDomain GetPatientInfo(PatientInfoDomain patientInfoDomain);
    }
}
