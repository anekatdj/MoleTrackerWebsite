using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class PatientDataDomain
    {
        public PatientDataDomain()
        {
            CollectionList = new List<CollectionDomain>();

            CollectionList.Add(new CollectionDomain("Mærke på overarm"));
            CollectionList.Add(new CollectionDomain("Mærke på underrarm"));
            CollectionList.Add(new CollectionDomain("Mærke på venstre balle"));
            CollectionList.Add(new CollectionDomain("Mærke på næsen"));
            CollectionList.Add(new CollectionDomain("Mærke på halsen"));
            CollectionList.Add(new CollectionDomain("Mærke på hånden"));
            CollectionList.Add(new CollectionDomain("Mærke i panden"));
            CollectionList.Add(new CollectionDomain("Mærke på anklen"));
            CollectionList.Add(new CollectionDomain("Mærke lige over navlen"));
            CollectionList.Add(new CollectionDomain("Mærke på højre skulderblad"));
            CollectionList.Add(new CollectionDomain("Mærke på lænden"));
        }
        public int PatientID { get; set; }
        public List<CollectionDomain> CollectionList { get; set; }
        public PatientInfoDomain PatientInfo { get; set; }
    }
}
