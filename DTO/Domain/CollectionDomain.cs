using DataClasses.PictureDTO;
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

        public CollectionDTO.CollectionDTO ToDTO()
        {
            List<PictureInfoDTO> list = new List<PictureInfoDTO>() { };
            foreach (PictureInfoDomain item in PictureList)
            {
                list.Add(item.ToDTO());
            }
            CollectionDTO.CollectionDTO collectionDTO = new CollectionDTO.CollectionDTO()
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
