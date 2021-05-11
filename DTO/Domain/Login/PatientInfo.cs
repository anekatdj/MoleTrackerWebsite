﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataClasses.Domain.Login
{
    public class PatientInfo
    {
        public int PatientID { get; set; }

        public string CPR { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}