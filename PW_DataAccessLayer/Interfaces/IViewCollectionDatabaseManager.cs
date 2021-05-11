﻿using DataClasses.Domain.Picture;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;

namespace PW_DataAccessLayer.Interfaces
{
    public interface IViewCollectionDatabaseManager
    {
        PictureData GetCollection(PictureInfo pictureInfo);
        Collection GetCollection();
        public PatientData GetPatientData(PatientInfo patientInfoDomain);
    }
}