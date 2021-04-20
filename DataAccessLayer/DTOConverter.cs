using DataClasses.CollectionDTO;
using DataClasses.Domain;
using DataClasses.MISCDTO;
using DataClasses.PictureDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    static class DTOConverter
    {
        public static CollectionDomain CollectionToDomain(CollectionDTO collectionDTO)
        {
            List<PictureInfoDomain> list = new List<PictureInfoDomain>() { };
            foreach (PictureInfoDTO item in collectionDTO.PictureList)
            {
                list.Add(item.ToDomain());
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
