using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class ChangeCollectionMarkingDomain : SessionInfoDomain
    {
        public int CollectionID { get; set; }
        public bool IsMarked { get; set; }
    }
}
