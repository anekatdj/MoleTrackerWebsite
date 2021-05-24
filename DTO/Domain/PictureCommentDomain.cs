using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class PictureCommentDomain
    {
        public int PictureID { get; set; }
        public string Comment { get; set; }
        public PictureCommentDTO ToDTO()
        {
            PictureCommentDTO pictureCommentDTO = new PictureCommentDTO()
            {
                PictureID = PictureID,
                Comment = Comment,
            };
            return pictureCommentDTO;
        }
    }
}
