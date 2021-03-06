using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO.CollectionDTOS;
using DataClasses.DTO.LoginDTOS;

namespace DataClasses.DTO.MISCDTOS
{
    public class PatientDataDTO
    {
        public int PatientID { get; set; }
        public List<CollectionDTO> CollectionList { get; set; }
        public PatientInfoDTO PatientInfo { get; set; }
    }
}
