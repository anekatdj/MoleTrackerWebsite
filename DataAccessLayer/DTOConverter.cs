using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DataObjects.DTO;
using DataClasses.DTO;
using CollectionDTO = DataClasses.CollectionDTO.CollectionDTO;
using DoctorContactInfoDTO = DataClasses.MISCDTO.DoctorContactInfoDTO;
using LocationOnBodyDTO = DataClasses.CollectionDTO.LocationOnBodyDTO;
using PictureInfoDTO = DataClasses.PictureDTO.PictureInfoDTO;

namespace DataAccessLayer
{
    static class DTOConverter
    {
        public static CollectionDomain CollectionToDomain(CollectionDTO collectionDTO)
        {
            List<PictureInfoDomain> list = new List<PictureInfoDomain>() { };
            foreach (PictureInfoDTO item in collectionDTO.PictureList)
            {
                list.Add(PictureInfoToDomain(item));
            }
            CollectionDomain collectionDomain = new CollectionDomain()
            {
                CollectionID = collectionDTO.CollectionID,
                CollectionName = collectionDTO.CollectionName,
                PictureList = list,
                Location = LocationOnBodyToDomain(collectionDTO.Location)
            };
            return collectionDomain;
        }
        public static LocationOnBodyDomain LocationOnBodyToDomain(LocationOnBodyDTO locationOnBodyDTO)
        {
            LocationOnBodyDomain locationOnBodyDomain = new LocationOnBodyDomain()
            {
                xCoordinate = locationOnBodyDTO.xCoordinate,
                yCoordinate = locationOnBodyDTO.yCoordinate,
                BodyPart = locationOnBodyDTO.BodyPart,
                BodyPartSide = locationOnBodyDTO.BodyPartSide,
                IsFrontFacing = locationOnBodyDTO.IsFrontFacing
            };
            return locationOnBodyDomain;
        }
        public static PictureInfoDomain PictureInfoToDomain(PictureInfoDTO pictureInfoDTO)
        {
            PictureInfoDomain pictureInfoDomain = new PictureInfoDomain()
            {
                CollectionID = pictureInfoDTO.CollectionID,
                DateOfUpload = pictureInfoDTO.DateOfUpload,
                PictureID = pictureInfoDTO.PictureID
            };
            return pictureInfoDomain;
        }

        public static DoctorInfoDomain DoctorInfoToDomain(DoctorInfoDTO doctorInfoDTO)
        {
            DoctorInfoDomain doctorInfoDomain = new DoctorInfoDomain()
            {
                DoctorID = doctorInfoDTO.DoctorID
            };
            return doctorInfoDomain;
        }

        public static LoginInfoDomain LoginInfoToDomain(LoginInfoDTO loginInfoDTO)
        {
            LoginInfoDomain loginInfoDomain = new LoginInfoDomain()
            {
                Username = loginInfoDTO.Username,
                Password = loginInfoDTO.Password
            };
            return loginInfoDomain;
        }

        public static PatientInfoDomain PatientInfoToDomain(PatientInfoDTO patientInfoDTO)
        {
            PatientInfoDomain patientInfoDomain = new PatientInfoDomain()
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

        public static SessionInfoDomain SessionInfoToDomain(SessionInfoDTO sessionInfoDTO)
        {
            SessionInfoDomain sessionInfoDomain = new SessionInfoDomain()
            {
                SessionID = sessionInfoDTO.SessionID,
                LoginID = sessionInfoDTO.LoginID,
                LoginType = sessionInfoDTO.LoginType
            };
            return sessionInfoDomain;
        }

        public static MedicalPracticePatientsDomain MedicalPracticePatientsToDomain(
            MedicalPracticePatientsDTO medicalPracticePatientsDTO)
        {
            List<PatientInfoDomain> list = new List<PatientInfoDomain>() { };
            foreach (PatientInfoDTO item in medicalPracticePatientsDTO.PatientList)
            {
                list.Add(PatientInfoToDomain(item));
            }

            MedicalPracticePatientsDomain medicalPracticePatientsDomain = new MedicalPracticePatientsDomain()
            {
                MedicalPracticeID = medicalPracticePatientsDTO.MedicalPracticeID,
                PatientList = list
            };
            return medicalPracticePatientsDomain;
        }

        public static DoctorContactInfoDomain DoctorContactInfoToDomain(DoctorContactInfoDTO doctorContactInfoDTO)
        {
            DoctorContactInfoDomain doctorContactInfoDomain = new DoctorContactInfoDomain()
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
    }
}
