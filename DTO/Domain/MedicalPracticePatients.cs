using DataClasses.LoginDTO;
using System.Collections.Generic;

namespace DataClasses.Domain
{
    public class MedicalPracticePatients
    {
        public int MedicalPracticeID { get; set; }
        public List<PatientInfoDTO> PatientList { get; set; }
    }
}