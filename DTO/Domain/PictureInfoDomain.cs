using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class PictureInfoDomain
    {
        public int PictureID { get; set; }
        public int CollectionID { get; set; }
        public DateTime DateOfUpload { get; set; }

        public PictureInfoDomain()
        {
            
        }
        public PictureInfoDomain(int pictureID)
        {
            PictureID = pictureID;
        }
        public PictureInfoDTO ToDTO()
        {
            PictureInfoDTO pictureInfoDTO = new PictureInfoDTO()
            {
                PictureID = PictureID,
                CollectionID = CollectionID,
                DateOfUpload = DateOfUpload
            };
            return pictureInfoDTO;
        }
    }
}
