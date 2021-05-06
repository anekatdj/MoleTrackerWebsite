using DataClasses.Domain.Picture;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IChangeComment
    {
        public void HandleComment(PictureComment pictureComment);
    }
}