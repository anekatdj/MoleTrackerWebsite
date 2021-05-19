﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain.MISC
{
    public class DoctorContactInfo
    {
        public int DoctorContactID { get; set; }
        public int MedicalPracticeID { get; set; }

        public string MedicalPracticeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public List<string> OpeningHours { get; set; }
        public string Website { get; set; }
    }
}
