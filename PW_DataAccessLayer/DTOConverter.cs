using System.Collections.Generic;
using DataClasses.DataObjects.DTO;
using DataClasses.Domain;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;
using DataClasses.Domain.Picture;
using DataClasses.DTO;

namespace PW_DataAccessLayer
{
    static class DTOConverter
    {
        public static Collection CollectionToDomain(CollectionDTO collectionDTO)
        {
            List<PictureInfo> list = new List<PictureInfo>() { };
            foreach (PictureInfoDTO item in collectionDTO.PictureList)
            {
                list.Add(PictureInfoToDomain(item));
            }
            Collection collectionDomain = new Collection()
            {
                CollectionID = collectionDTO.CollectionID,
                CollectionName = collectionDTO.CollectionName,
                PictureList = list,
                Location = LocationOnBodyToDomain(collectionDTO.Location)
            };
            return collectionDomain;
        }
        public static LocationOnBody LocationOnBodyToDomain(LocationOnBodyDTO locationOnBodyDTO)
        {
            LocationOnBody locationOnBodyDomain = new LocationOnBody()
            {
                xCoordinate = locationOnBodyDTO.xCoordinate,
                yCoordinate = locationOnBodyDTO.yCoordinate,
                //BodyParts = locationOnBodyDTO.BodyPartSide, //TODO skal være en enum i DTO, ikke en string
                IsFrontFacing = locationOnBodyDTO.IsFrontFacing
            };
            return locationOnBodyDomain;
        }
        public static PictureInfo PictureInfoToDomain(PictureInfoDTO pictureInfoDTO)
        {
            PictureInfo pictureInfoDomain = new PictureInfo()
            {
                CollectionID = pictureInfoDTO.CollectionID,
                DateOfUpload = pictureInfoDTO.DateOfUpload,
                PictureID = pictureInfoDTO.PictureID
            };
            return pictureInfoDomain;
        }

        public static PictureData PictureDataToDomain(PictureDataDTO pictureDataDTO)
        {
            PictureData pictureDataDomain = new PictureData()
            {
                PicData = pictureDataDTO.PictureData,
                PictureID = pictureDataDTO.PictureID
            };
            return pictureDataDomain;
        }

        public static DoctorInfo DoctorInfoToDomain(DoctorInfoDTO doctorInfoDTO)
        {
            DoctorInfo doctorInfoDomain = new DoctorInfo()
            {
                DoctorContactID = doctorInfoDTO.DoctorID
            };
            return doctorInfoDomain;
        }

        public static LogInInfo LoginInfoToDomain(LoginInfoDTO loginInfoDTO)
        {
            LogInInfo loginInfoDomain = new LogInInfo()
            {
                Username = loginInfoDTO.Username,
                Password = loginInfoDTO.Password
            };
            return loginInfoDomain;
        }

        public static PatientInfo PatientInfoToDomain(PatientInfoDTO patientInfoDTO)
        {
            PatientInfo patientInfoDomain = new PatientInfo()
            {
                CPR = patientInfoDTO.CPR,
                Email = patientInfoDTO.Email,
                Gender = patientInfoDTO.Gender,
                Name = patientInfoDTO.Name,
                PhoneNumber = patientInfoDTO.PhoneNumber,
                PatientID = patientInfoDTO.PatientID
            };
            return patientInfoDomain;
        }

        public static PatientData PatientDataToDomain(PatientDataDTO patientDataDTO)
        {
            List<Collection> list = new List<Collection>() { };
            foreach (CollectionDTO item in patientDataDTO.CollectionList)
            {
                list.Add(CollectionToDomain(item));
            }

            PatientData patientDataDomain = new PatientData()
            {
                CollectionList = list,
                PatientInfo = PatientInfoToDomain(patientDataDTO.PatientInfo),
                PatientID = patientDataDTO.patientId
            };
            return patientDataDomain;
        }

        public static SessionInfo SessionInfoToDomain(SessionInfoDTO sessionInfoDTO)
        {
            SessionInfo sessionInfoDomain = new SessionInfo()
            {
                SessionID = sessionInfoDTO.SessionID,
                LoginID = sessionInfoDTO.LoginID,
                LoginType = sessionInfoDTO.LoginType
            };
            return sessionInfoDomain;
        }

        //public static MedicalPracticePatients MedicalPracticePatientsToDomain(MedicalPracticePatientsDTO medicalPracticePatientsDTO)
        //{
        //    List<PatientInfo> list = new List<PatientInfo>() { };
        //    foreach (PatientInfoDTO item in medicalPracticePatientsDTO.PatientList)
        //    {
        //        list.Add(PatientInfoToDomain(item));
        //    }

        //    MedicalPracticePatients medicalPracticePatientsDomain = new MedicalPracticePatients()
        //    {
        //        MedicalPracticeID = medicalPracticePatientsDTO.MedicalPracticeID,
        //        PatientList = list
        //    };
        //    return medicalPracticePatientsDomain;
        //}

        public static DoctorInfo DoctorContactInfoToDomain(DoctorContactInfoDTO doctorContactInfoDTO)
        {
            DoctorInfo doctorContactInfoDomain = new DoctorInfo()
            {
                DoctorContactID = doctorContactInfoDTO.DoctorContactID,
                MedicalPracticeID = doctorContactInfoDTO.MedicalPracticeID,
                MedicalPracticeName = doctorContactInfoDTO.MedicalPracticeName,
                PhoneNumber = doctorContactInfoDTO.PhoneNumber,
                Adress = doctorContactInfoDTO.Adress,
                OpeningHours = doctorContactInfoDTO.OpeningHours,
                Website = doctorContactInfoDTO.Website
            };
            return doctorContactInfoDomain;
        }

        public static PictureComment PictureCommentToDomain(PictureCommentDTO pictureCommentDTO)
        {
            PictureComment pictureCommentDomain = new PictureComment()
            {
                PictureID = pictureCommentDTO.PictureID,
                Comment = pictureCommentDTO.Comment
            };
            return pictureCommentDomain;
        }
    }
}