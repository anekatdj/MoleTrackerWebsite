using DataClasses.Domain.Picture;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IViewCollectionDatabaseManager
    {
        PictureData GetPictures(PictureInfo pictureInfo);
        public PatientData GetPatientData(PatientInfo patientInfoDomain);
        byte[] LoadSpecificPicture(int pictureID);
        PictureComment GetPictureComment(PictureInfo pictureInfo);
        public void GetExistingCollection(Collection collection);
    }
}