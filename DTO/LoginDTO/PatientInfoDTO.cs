﻿namespace DataClasses.LoginDTO
{
    public class PatientInfoDTO
    {
        public PatientInfoDTO(string CPR, string name)
        {
            this.CPR = CPR;
            this.Name = name;
        }
        public int PatientID { get; set; }

        public string CPR { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
