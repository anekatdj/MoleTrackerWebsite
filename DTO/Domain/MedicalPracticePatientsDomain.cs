using DataClasses.LoginDTO;
using System.Collections.Generic;

namespace DataClasses.Domain
{
    public class MedicalPracticePatientsDomain
    {
        //Constructer lavet for at snyde med patienter
        public MedicalPracticePatientsDomain()
        {
            PatientList = new List<PatientInfoDTO>();
            PatientList.Add(new PatientInfoDTO("123456-7890", "Belinda"));
            PatientList.Add(new PatientInfoDTO("234567-8901", "Jacob"));
            PatientList.Add(new PatientInfoDTO("345678-9012", "Ane Kathrine"));
            PatientList.Add(new PatientInfoDTO("456789-0124", "Laura"));
        }
        public int MedicalPracticeID { get; set; }
        public List<PatientInfoDTO> PatientList { get; set; }
    }
}