using System.Collections.Generic;
using System.Text;
using DataClasses.Domain.Picture;
using DataClasses.DTO;

namespace DataClasses.Domain.Collections
{
    public class Collection : SessionInfo
    {
        public int CollectionID { get; set; }
        public List<PictureInfo> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBody Location { get; set; }

        public Collection()
        {
            PictureList = new List<PictureInfo>();
            PictureList.Add(new PictureInfo(1));
            PictureList.Add(new PictureInfo(2));
            PictureList.Add(new PictureInfo(3));
            PictureList.Add(new PictureInfo(4));
            PictureList.Add(new PictureInfo(5));
            PictureList.Add(new PictureInfo(6));
            PictureList.Add(new PictureInfo(7));
            PictureList.Add(new PictureInfo(8));
            PictureList.Add(new PictureInfo(9));
            PictureList.Add(new PictureInfo(10));
        }
        public Collection(string collectionName)
        {
            CollectionName = collectionName;
        }

        public CollectionDTO ToDTO(LocationOnBody.BodyPart bodyPart)
        {
            List<PictureInfoDTO> list = new List<PictureInfoDTO>() { };
            foreach (PictureInfo item in PictureList)
            {
                list.Add(item.ToDTO());
            }
            CollectionDTO collectionDTO = new CollectionDTO()
            {
                CollectionID = CollectionID,
                CollectionName = CollectionName,
                PictureList = list,
                Location = Location.ToDTO(bodyPart)
            };
            return collectionDTO;
        }
    }
}
