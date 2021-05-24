using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class DoctorContactInfoRequestDomain
    {
        public int DoctorContactID { get; set; }

        public DoctorContactInfoRequestDTO ToDTO()
        {
            DoctorContactInfoRequestDTO doctorContactInfoRequestDTO = new DoctorContactInfoRequestDTO()
            {
                DoctorContactID = DoctorContactID
            };
            return doctorContactInfoRequestDTO;
        }
    }
}
