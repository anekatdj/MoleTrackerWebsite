using DataClasses.Domain.Picture;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IViewCollectionController
    {
        PictureData HandleCollection(PictureInfo pictureInfo);
    }
}