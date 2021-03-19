﻿using System;
using System.Collections.Generic;
using System.Text;
using DTO.CollectionDTOS;
using DTO.LoginDTOS;

namespace DTO.MISCDTOS
{
    public class PatientDataDTO
    {
        public int PatientID { get; set; }
        public List<CollectionDTO> CollectionList { get; set; }
        public PatientInfoDTO PatientInfo { get; set; }
    }
}
