using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IUploadPictureController
    {
        public Collection collection { get; set; }
        public void UploadPicture(byte[] newDataBytes, PictureInfo pictureInfo);
    }
}