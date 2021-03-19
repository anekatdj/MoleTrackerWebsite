using System;
using System.Collections.Generic;
using System.Text;
using DTO.LoginDTOS;

namespace DTO.MISCDTOS
{
    public class MedicalPracticePatientsDTO
    {
        public int MedicalPracticeID { get; set; }
        public List<PatientInfoDTO> PatientList { get; set; }
    }
}
