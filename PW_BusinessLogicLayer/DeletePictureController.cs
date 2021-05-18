using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using DataClasses.Domain.Picture;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class DeletePictureController : IDeletePictureController
    {
        private IDeletePictureDatabaseManager deletePictureDatabaseManager;

        public DeletePictureController()
        {
            deletePictureDatabaseManager = new DeletePictureDatabaseManager();
        }

        public void HandleDeletePicture(PictureInfo pictureInfo)
        {
            deletePictureDatabaseManager.DeletePicture(pictureInfo);
        }
    }
}