﻿using System;
using System.Collections.Generic;
using System.Text;
using DTO.LoginDTO;

namespace DTO.MISCDTO
{
    public class PatientDataDTO
    {
        public int PatientID { get; set; }
        public List<CollectionDTO.CollectionDTO> CollectionList { get; set; }
        public PatientInfoDTO PatientInfo { get; set; }
    }
}
