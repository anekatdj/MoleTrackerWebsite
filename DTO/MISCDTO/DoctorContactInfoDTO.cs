using System.Collections.Generic;
using DataClasses.Domain;

namespace DataClasses.MISCDTO
{
    public class DoctorContactInfoDTO
    {
        public int DoctorContactID { get; set; }
        public int MedicalPracticeID { get; set; }

        public string MedicalPracticeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public List<string> OpeningHours { get; set; }
        public string Website { get; set; }

        public DoctorContactInfoDomain ToDomain()
        {
            DoctorContactInfoDomain doctorContactInfoDomain = new DoctorContactInfoDomain()
            {
                DoctorContactID = DoctorContactID,
                MedicalPracticeID = MedicalPracticeID,
                MedicalPracticeName = MedicalPracticeName,
                PhoneNumber = PhoneNumber,
                Adress = Adress,
                OpeningHours = OpeningHours,
                Website = Website
            };
            return doctorContactInfoDomain;
        }
    }
}
