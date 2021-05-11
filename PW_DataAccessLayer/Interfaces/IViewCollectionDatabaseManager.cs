using DataClasses.Domain.Picture;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IViewCollectionDatabaseManager
    {
        PictureData GetCollection(PictureInfo pictureInfo);
    }
}