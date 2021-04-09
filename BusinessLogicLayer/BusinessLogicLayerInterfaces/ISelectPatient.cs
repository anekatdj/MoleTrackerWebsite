using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.MISCDTO;
using DataClasses.LoginDTO;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ISelectPatient
    {
        void GetPatientData(PatientInfoDomain patientInfoDomain);
    }
}
