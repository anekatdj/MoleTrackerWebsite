using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class DeletePictureController : IDeletePictureController
    {
        private IDeletePictureDatabaseManager deletePictureDatabaseManager;

        //public void HandleDeletePicture(Collection collection, PatientInfo patientInfo)
        //{
        //    deletePictureDatabaseManager = new DeletePictureDatabaseManager();

        //    deleteCollection.DeleteCollection(collection, patientInfo);
        //}
    }
}