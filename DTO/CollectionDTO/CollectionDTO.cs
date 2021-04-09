using System.Collections.Generic;
using DataClasses.PictureDTO;

namespace DataClasses.CollectionDTO
{
    public class CollectionDTO
    {
        public int CollectionID { get; set; }
        public List<PictureInfoDTO> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBodyDTO Location { get; set; }
    }
}
