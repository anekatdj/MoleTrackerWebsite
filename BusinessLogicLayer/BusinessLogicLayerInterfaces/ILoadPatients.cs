using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILoadPatients
    {
         MedicalPracticePatientsDomain LoadPatientList(DoctorInfoDomain doctorInfoDomain);
    }
}
