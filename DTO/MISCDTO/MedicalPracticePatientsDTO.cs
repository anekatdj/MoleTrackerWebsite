using System;
using System.Collections.Generic;
using System.Text;
using DTO.LoginDTO;

namespace DTO.MISCDTO
{
    public class MedicalPracticePatientsDTO
    {
        public int MedicalPracticeID { get; set; }
        public List<PatientInfoDTO> PatientList { get; set; }
    }
}
