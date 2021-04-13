using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.LoginDTO;

namespace DataClasses.Domain
{
    public class DoctorInfoDomain
    {
        public int DoctorID { get; set; }

        public DoctorInfoDTO ToDTO()
        {
            DoctorInfoDTO doctorInfoDto = new DoctorInfoDTO()
            {
                DoctorID = DoctorID
            };
            return doctorInfoDto;
        }
    }
}
