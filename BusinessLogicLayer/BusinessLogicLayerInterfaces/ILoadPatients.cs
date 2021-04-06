using System;
using System.Collections.Generic;
using System.Text;
using DTO.LoginDTO;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILoadPatients
    {
        void LoadPatientList(DoctorInfoDTO doctorInfo);
    }
}
