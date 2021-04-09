using System.Collections.Generic;
using DataClasses.Domain;
using DataClasses.LoginDTO;

namespace DataClasses.MISCDTO
{
    public class PatientDataDTO
    {
        public PatientDataDTO() { }
        public int PatientID { get; set; }
        public List<CollectionDTO.CollectionDTO> CollectionList { get; set; }
        public PatientInfoDTO PatientInfo { get; set; }
        //public PatientDataDomain ToDomain()
        //{
        //    PatientDataDomain patientDataDomain = new PatientDataDomain()
        //    {
        //        PatientID = PatientID
        //    };
        //    CollectionDTO.CollectionDTO collectionDTO new CollectionDTO.CollectionDTO()
        //    patientDataDomain.CollectionList = collectionDTO
        //}
    }
}
