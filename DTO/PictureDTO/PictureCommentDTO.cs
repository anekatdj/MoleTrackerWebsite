using DataClasses.Domain;

namespace DataClasses.PictureDTO
{
    public class PictureCommentDTO
    {
        public int PictureID { get; set; }
        public string Comment { get; set; }

        public PictureCommentDomain ToDomain()
        {
            PictureCommentDomain pictureCommentDomain = new PictureCommentDomain()
            {
                PictureID = PictureID,
                Comment = Comment
            };
            return pictureCommentDomain;
        } 
    }
}
