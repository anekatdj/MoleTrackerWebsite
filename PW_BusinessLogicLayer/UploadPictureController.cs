using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class UploadPictureController : IUploadPictureController
    {
        private IUploadPictureDatabaseManager _uploadPictureDatabaseManager;
        public Collection collection { get; set; }

        public UploadPictureController()
        {
            _uploadPictureDatabaseManager = new UploadPictureDatabaseManager(collection);
        }

        public void UploadPicture(byte[] newDataBytes, PictureInfo pictureInfo)
        {
            _uploadPictureDatabaseManager.UploadPictureToDatabase(newDataBytes, pictureInfo);
        }
    }
}