using DataClasses.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class DoctorInfoDomain: SessionInfoDomain
    {
        public int DoctorID { get; set; }
        public int Clinic { get; set; }

        public DoctorInfoDTO ToDTO()
        {
            DoctorInfoDTO doctorInfoDto = new DoctorInfoDTO()
            {
                DoctorID = DoctorID,
                clinic = Clinic
            };
            return doctorInfoDto;
        }
    }
}
