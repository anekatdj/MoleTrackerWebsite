﻿using System;
using APIWebServiesConnector;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;
using APIWebServiesConnector.APIStringFabrics;
using DataAccessLayer;

namespace PW_DataAccessLayer
{
    public class ViewCollectionDatabaseManager : IViewCollectionDatabaseManager
    {

        private IAPIService API;

        public ViewCollectionDatabaseManager()
        {
            //API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());

            //API = new StubApiService();

            
            API= APIFactory.GetAPI("");
        }

        public PictureData GetCollection(PictureInfo pictureInfo) //PatientInfo patientInfo
        {
            PictureDataDTO pictureDataDTO = new PictureDataDTO();
            PictureRequestDTO pictureRequestDTO = new PictureRequestDTO() {PictureID = pictureInfo.PictureID};

            try
            {
                pictureDataDTO = API.GetObject<PictureDataDTO, PictureRequestDTO>("GetPictureData", pictureRequestDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            PictureData pictureData = DTOConverter.PictureDataToDomain(pictureDataDTO); 

            return pictureData;
        }

        //Den her er nok egentlig magen til den ovenfor 😅
        public byte[] LoadSpecificPicture(int PictureID)
        {
            PictureRequestDTO PictureRequest = new PictureRequestDTO();
            PictureRequest.PictureID = PictureID;
            PictureDataDTO PictureFromApi = API.GetObject<PictureDataDTO, PictureRequestDTO>("GetPictureData", PictureRequest);

            return PictureFromApi.PictureData;

        }

        public PatientData GetPatientData(PatientInfo patientInfoDomain)
        {
            PatientDataDTO patientDataDTO = new PatientDataDTO();
            PatientInfoRequestDTO patientInfoRequestDTO = new PatientInfoRequestDTO() { PatientID = patientInfoDomain.PatientID };
            try
            {
                patientDataDTO = API.GetObject<PatientDataDTO, PatientInfoRequestDTO>("GetPatientData", patientInfoRequestDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            PatientData patientDataDomain = DTOConverter.PatientDataToDomain(patientDataDTO);

            return patientDataDomain;
        }

    }
}