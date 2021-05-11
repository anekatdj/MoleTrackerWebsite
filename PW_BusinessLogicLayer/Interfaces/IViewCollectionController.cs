using DataClasses.Domain.Picture;

using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IViewCollectionController
    {
        PictureData HandleCollection(PictureInfo pictureInfo);

        public PatientData GetPatientData(PatientInfo patientInfoDomain);
    }
}