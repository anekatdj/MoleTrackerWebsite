using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO.PictureDTOs;
using DTO.CollectionDTOS;

namespace DataClasses.DTO.CollectionDTOS
{
    public class CollectionDTO
    {
        public int CollectionID { get; set; }
        public List<PictureInfoDTO> PictureList { get; set; }
        public string CollectionName { get; set; }
        public LocationOnBodyDTO Location { get; set; }
    }
}
