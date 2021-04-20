using System.Collections.Generic;

namespace DataClasses.Domain
{
    public class MedicalPracticePatientsDomain
    {
        //Constructer lavet for at snyde med patienter
        public MedicalPracticePatientsDomain()
        {
            PatientList = new List<PatientInfoDomain>();
            PatientList.Add(new PatientInfoDomain("123456-7890", "Belinda"));
            PatientList.Add(new PatientInfoDomain("234567-8901", "Jacob"));
            PatientList.Add(new PatientInfoDomain("345678-9012", "Ane Kathrine"));
            PatientList.Add(new PatientInfoDomain("456789-0124", "Laura"));
        }
        public int MedicalPracticeID { get; set; }
        public List<PatientInfoDomain> PatientList { get; set; }
    }
}