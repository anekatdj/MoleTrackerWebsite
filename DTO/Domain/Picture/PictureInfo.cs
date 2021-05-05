using System;
using System.Collections.Generic;
using System.Text;

namespace DataClasses.Domain.Picture
{
    public class PictureInfo
    {
        public int PictureID { get; set; } = 1;
        public int CollectionID { get; set; } = 1;
        public DateTime DateOfUpload { get; set; } = new DateTime(2021, 02, 21);
    }
}
