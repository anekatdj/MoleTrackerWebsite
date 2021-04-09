using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.MISCDTO;
using DataClasses.LoginDTO;


namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ISelectPatient
    {
        void GetPatientData(PatientInfoRequestDTO patientInfoRequest);
    }
}
