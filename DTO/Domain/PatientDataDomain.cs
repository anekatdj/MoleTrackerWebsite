using DataClasses.LoginDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class PatientDataDomain
    {
        public int PatientID { get; set; }
        public List<CollectionDTO.CollectionDTO> CollectionList { get; set; }
        public PatientInfoDTO PatientInfo { get; set; }
    }
}
