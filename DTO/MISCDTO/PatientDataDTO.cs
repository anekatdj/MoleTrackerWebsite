using System.Collections.Generic;
using DataClasses.Domain;
using DataClasses.LoginDTO;

namespace DataClasses.MISCDTO
{
    public class PatientDataDTO
    {
        public int PatientID { get; set; }
        public List<CollectionDTO.CollectionDTO> CollectionList { get; set; }
        public PatientInfoDTO PatientInfo { get; set; }

        public PatientDataDomain ToDomain()
        {
            List<CollectionDomain> list = new List<CollectionDomain>();
            foreach (CollectionDTO.CollectionDTO item in CollectionList)
            {
                list.Add(item.ToDomain());
            }
            PatientDataDomain patientDataDomain = new PatientDataDomain()
            {
                PatientID = PatientID,
                CollectionList = list,
                PatientInfo = PatientInfo.ToDomain()
            };
            return patientDataDomain;
        }
    }
}
