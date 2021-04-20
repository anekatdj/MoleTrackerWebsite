using DataClasses.Domain;
using DataClasses.LoginDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataAccessLayerInterfaces
{
    public interface ILoadPatientsDatabaseManager
    {
        MedicalPracticePatientsDomain GetMedicalPracticePatients(DoctorInfoDomain doctorInfoDomain);
    }
}
