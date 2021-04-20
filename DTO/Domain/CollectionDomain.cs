
using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class CollectionDomain
    {
        public int CollectionID { get; set; }
        public List<PictureInfoDomain> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBodyDomain Location { get; set; }

        public CollectionDTO ToDTO()
        {
            List<PictureInfoDTO> list = new List<PictureInfoDTO>() { };
            foreach (PictureInfoDomain item in PictureList)
            {
                list.Add(item.ToDTO());
            }
            CollectionDTO collectionDTO = new CollectionDTO()
            {
                CollectionID = CollectionID,
                CollectionName = CollectionName,
                PictureList = list,
                Location = Location.ToDTO()
            };
            return collectionDTO;
        }
    }
}
