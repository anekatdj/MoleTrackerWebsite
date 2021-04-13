using System.Collections.Generic;
using DataClasses.Domain;
using DataClasses.LoginDTO;

namespace DataClasses.MISCDTO
{
    public class MedicalPracticePatientsDTO
    {
        public int MedicalPracticeID { get; set; }
        public List<PatientInfoDTO> PatientList { get; set; }

        public MedicalPracticePatientsDomain ToDomain()
        {
            List<PatientInfoDomain> list = new List<PatientInfoDomain>() { };
            foreach (PatientInfoDTO item in PatientList)
            {
                list.Add(item.ToDomain());
            }
            MedicalPracticePatientsDomain medicalPracticePatientsDomain = new MedicalPracticePatientsDomain()
            {
                MedicalPracticeID = MedicalPracticeID,
                PatientList = list
            };
            return medicalPracticePatientsDomain;
        }
    }
}
