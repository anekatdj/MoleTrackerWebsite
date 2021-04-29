using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain
{
    public class Collection
    {
        public int CollectionID { get; set; }
        public List<PictureInfo> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBody Location { get; set; }
    }
}
