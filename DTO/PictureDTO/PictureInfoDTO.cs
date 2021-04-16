using System;
using DataClasses.Domain;

namespace DataClasses.PictureDTO
{
    public class PictureInfoDTO
    {
        public int PictureID { get; set; }
        public int CollectionID { get; set; }
        public DateTime DateOfUpload { get; set; }

        public PictureInfoDomain ToDomain()
        {
            PictureInfoDomain pictureInfoDomain = new PictureInfoDomain()
            {
                CollectionID = CollectionID,
                PictureID = PictureID,
                DateOfUpload = DateOfUpload
            };
            return pictureInfoDomain;
        }
    }
}
