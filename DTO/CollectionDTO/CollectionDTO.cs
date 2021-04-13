using System.Collections.Generic;
using DataClasses.Domain;
using DataClasses.PictureDTO;

namespace DataClasses.CollectionDTO
{
    public class CollectionDTO
    {
        public int CollectionID { get; set; }
        public List<PictureInfoDTO> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBodyDTO Location { get; set; }

        public CollectionDomain ToDomain()
        {
            List<PictureInfoDomain> list = new List<PictureInfoDomain>() { };
            foreach (PictureInfoDTO item in PictureList)
            {
                list.Add(item.ToDomain());
            }
            CollectionDomain collectionDomain = new CollectionDomain()
            {
                CollectionID = CollectionID,
                CollectionName = CollectionName,
                PictureList = list,
                Location = Location.ToDomain()
            };
            return collectionDomain;
        }
    }
}
