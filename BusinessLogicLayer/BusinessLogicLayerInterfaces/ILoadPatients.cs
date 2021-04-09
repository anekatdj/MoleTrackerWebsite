using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.LoginDTO;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILoadPatients
    {
        void LoadPatientList(DoctorInfoDTO doctorInfo);
    }
}
