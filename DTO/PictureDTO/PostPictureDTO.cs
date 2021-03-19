using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.PictureDTO
{
    public class PostPictureDTO
    {
        public PictureInfoDTO Info { get; set; }
        public PictureDataDTO Data { get; set; }
        public PictureCommentDTO Comment { get; set; }
    }
}
