using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using DataClasses.LoginDTO;
using DataClasses.MISCDTO;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILoadPatients
    {
        void LoadPatientList(MedicalPracticePatientsDomain patients);
    }
}
