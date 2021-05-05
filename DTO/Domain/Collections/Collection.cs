using System.Collections.Generic;
using System.Text;
using DataClasses.Domain.Picture;

namespace DataClasses.Domain.Collections
{
    public class Collection : SessionInfo
    {
        public int CollectionID { get; set; }
        public List<PictureInfo> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBody Location { get; set; }
    }
}
