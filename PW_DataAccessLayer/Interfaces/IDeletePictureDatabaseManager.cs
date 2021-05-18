using DataClasses.Domain.Picture;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IDeletePictureDatabaseManager
    {
        public void DeletePicture(PictureInfo pictureInfo);
    }
}