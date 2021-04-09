using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class PatientInfoDomain
    {
        public int PatientID { get; set; }
        public string CPR { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

