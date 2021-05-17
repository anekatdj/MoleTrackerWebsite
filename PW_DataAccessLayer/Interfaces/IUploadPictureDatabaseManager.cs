using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IUploadPictureDatabaseManager
    {
        public Collection Collection { get; set; }
        public void UploadPictureToDatabase(byte[] newDataBytes, PictureInfo pictureInfo);
    }
}