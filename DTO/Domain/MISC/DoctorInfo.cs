using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain.MISC
{
    public class DoctorInfo
    {
        public int DoctorContactID { get; set; }
        public int MedicalPracticeID { get; set; }

        public string MedicalPracticeName { get; set; } = "AKs læge";
        public string PhoneNumber { get; set; } = "12 34 56 78";
        public string Adress { get; set; } = "Pepsi Max Stræde 144,\n8210 Aarhus V";
        public List<string> OpeningHours { get; set; }
        public string Website { get; set; } = "www.AK47theDoctor.dk";
    }
}
