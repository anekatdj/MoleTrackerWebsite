using System.Collections.Generic;
using DataClasses.LoginDTO;

namespace DataClasses.MISCDTO
{
    public class MedicalPracticePatientsDTO
    {
        public int MedicalPracticeID { get; set; }
        public List<PatientInfoDTO> PatientList { get; set; }
    }
}
