using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataClasses.Domain.Login
{
    public class PatientInfo
    {
        public int PatientID { get; set; }

        public string CPR { get; set; } = "2007981233";
        public string Name { get; set; } = "AK";
        public string Gender { get; set; } = "G";
        public string PhoneNumber { get; set; } = "24 84 09 48";
        public string Email { get; set; } = "AToTheK47@godmail.dk";
    }
}
