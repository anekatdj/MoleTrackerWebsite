using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.LoginDTO;
using DataClasses.MISCDTO;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILoadPatients
    {
        void LoadPatientList(MedicalPracticePatientsDTO patients);
    }
}
