using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ISelectPatient
    {
        PatientInfoDomain SelectedPatient { get; set; }
        void GetPatientData(PatientInfoDomain patientInfoDomain);
      
    }
}
