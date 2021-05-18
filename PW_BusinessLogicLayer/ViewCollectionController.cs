using DataClasses.Domain;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class ViewCollectionController : IViewCollectionController
    {
        private IViewCollectionDatabaseManager viewCollectionDatabaseManager;
        public Collection SelectedCollection { get; set; }

        public ViewCollectionController()
        {
            viewCollectionDatabaseManager = new ViewCollectionDatabaseManager();
        }

        public PictureData HandleCollection(PictureInfo pictureInfo)
        {
            return viewCollectionDatabaseManager.GetCollection(pictureInfo);
        }

        public byte[] HandleSpecificPicture(int pictureID)
        {
            return viewCollectionDatabaseManager.LoadSpecificPicture(pictureID);
        }
        public PatientData GetPatientData(PatientInfo patientInfoDomain)
        {
            return viewCollectionDatabaseManager.GetPatientData(patientInfoDomain);
        }

        public PictureComment HandlePictureComment(PictureInfo pictureInfo)
        {
            return viewCollectionDatabaseManager.GetPictureComment(pictureInfo);
        }
    }
}