using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class PatientDataDomain
    {
        public int PatientID { get; set; }
        public List<CollectionDomain> CollectionList { get; set; }
        public PatientInfoDomain PatientInfo { get; set; }
    }
}
