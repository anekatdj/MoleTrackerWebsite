using System;
using System.Collections.Generic;
using System.Text;
using DTO.LoginDTO;
using DTO.MISCDTO;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ISelectPatient
    {
        void GetPatientData(PatientInfoRequestDTO patientInfoRequest);
    }
}
