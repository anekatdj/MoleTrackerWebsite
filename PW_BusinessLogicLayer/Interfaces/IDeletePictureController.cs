using DataClasses.Domain.Picture;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IDeletePictureController
    {
        public void HandleDeletePicture(PictureInfo pictureInfo);
    }
}