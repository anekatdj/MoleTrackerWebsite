﻿using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;

using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IViewCollectionController
    {
        Collection SelectedCollection { get; set; }
        PictureData HandleCollection(PictureInfo pictureInfo);
        void GetCollectionFromDB(Collection collection);
        PatientData GetPatientData(PatientInfo patientInfoDomain);
        public byte[] HandleSpecificPicture(int pictureID);
        PictureComment HandlePictureComment(PictureInfo pictureInfo);
    }
}