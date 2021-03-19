using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.PictureDTOs
{
    public class PictureInfoDTO
    {
        public int PictureID { get; set; }
        public int CollectionID { get; set; }
        public DateTime DateOfUpload { get; set; }
    }
}
