using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class CollectionDomain
    {
        public int CollectionID { get; set; }
        public List<PictureInfoDomain> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBodyDomain Location { get; set; }
    }
}
