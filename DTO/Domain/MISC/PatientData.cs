using System.Collections.Generic;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;

namespace DataClasses.Domain.MISC
{
    public class PatientData
    {
        public int PatientID { get; set; }
        public List<Collection> CollectionList { get; set; }
        public PatientInfo PatientInfo { get; set; }
    }
}