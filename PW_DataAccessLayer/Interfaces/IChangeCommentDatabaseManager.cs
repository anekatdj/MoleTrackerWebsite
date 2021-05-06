using DataClasses.Domain.Picture;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IChangeCommentDatabaseManager
    {
        public void HandleChangedComment(PictureComment pictureComment);
    }
}