using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class CollectionDomain
    {
        public int PatientID { get; set; }
        public int CollectionID { get; set; }
        public List<PictureInfoDomain> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBodyDomain Location { get; set; }
        public bool IsMarked { get; set; }

        public CollectionDomain()
        {
            PictureList = new List<PictureInfoDomain>();
            PictureList.Add(new PictureInfoDomain(1));
            PictureList.Add(new PictureInfoDomain(2));
            PictureList.Add(new PictureInfoDomain(3));
            PictureList.Add(new PictureInfoDomain(4));
            PictureList.Add(new PictureInfoDomain(5));
            PictureList.Add(new PictureInfoDomain(6));
            PictureList.Add(new PictureInfoDomain(7));
            PictureList.Add(new PictureInfoDomain(8));
            PictureList.Add(new PictureInfoDomain(9));
            PictureList.Add(new PictureInfoDomain(10));
        }
        public CollectionDomain(string collectionName)
        {
            CollectionName = collectionName;
            //collectionName = CollectionName; 
            
        }
        public CollectionDTO ToDTO(LocationOnBodyDomain.BodyPart bodyPart)
        {
            List<PictureInfoDTO> list = new List<PictureInfoDTO>() { };
            foreach (PictureInfoDomain item in PictureList)
            {
                list.Add(item.ToDTO());
            }

            CollectionDTO collectionDTO = new CollectionDTO()
            {
                PatientID = PatientID,
                CollectionID = CollectionID,
                CollectionName = CollectionName,
                PictureList = list,
                Location = Location.ToDTO(bodyPart),
                IsMarked = IsMarked
            };
            return collectionDTO;
        }
    }
}
