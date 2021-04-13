using DataClasses.Domain;

namespace DataClasses.LoginDTO
{
    public class DoctorInfoDTO
    {
        public int DoctorID { get; set; }

        public DoctorInfoDomain ToDomain()
        {
            DoctorInfoDomain doctorInfoDomain = new DoctorInfoDomain() { DoctorID = DoctorID };
            return doctorInfoDomain;
        }
    }
}
