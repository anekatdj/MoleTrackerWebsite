using DataClasses.LoginDTO;
using System.Collections.Generic;

namespace DataClasses.Domain
{
    public class MedicalPracticePatientsDomain
    {
        public int MedicalPracticeID { get; set; }
        public List<PatientInfoDomain> PatientList { get; set; }
    }
}