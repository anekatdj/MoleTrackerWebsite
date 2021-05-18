using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain.Picture
{
    public class PictureInfo
    {
        public int PictureID { get; set; }
        public int CollectionID { get; set; }
        public DateTime DateOfUpload { get; set; }

        public PictureInfo(){}

        public PictureInfo(int pictureID)
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
