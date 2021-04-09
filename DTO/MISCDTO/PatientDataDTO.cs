using System.Collections.Generic;
using DataClasses.LoginDTO;

namespace DataClasses.MISCDTO
{
    public class PatientDataDTO
    {
        public int PatientID { get; set; }
        public List<CollectionDTO.CollectionDTO> CollectionList { get; set; }
        public PatientInfoDTO PatientInfo { get; set; }
    }
}
