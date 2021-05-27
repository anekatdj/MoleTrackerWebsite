using System;
using System.Linq;
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
        public PatientData CurrentPatientData { get; set; }

        public ViewCollectionDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);
        }

        public void GetExistingCollection(Collection collection)
        {
            CollectionRequestDTO collectionRequestDTO = new CollectionRequestDTO();
            CollectionDTO CollectionDTO = new CollectionDTO();
            collectionRequestDTO.CollectionID = collection.CollectionID;

            try
            {
                CollectionDTO = API.GetObject<CollectionDTO, CollectionRequestDTO>("GetCollection", collectionRequestDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            collection = DTOConverter.CollectionToDomain(CollectionDTO);
        }

        public PictureData GetPictures(PictureInfo pictureInfo)
        {
            PictureDataDTO pictureDataDTO = new PictureDataDTO();
            PictureRequestDTO pictureRequestDTO = new PictureRequestDTO() { PictureID = pictureInfo.PictureID };

            pictureDataDTO = API.GetObject<PictureDataDTO, PictureRequestDTO>("GetPictureData", pictureRequestDTO);

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


        public PictureComment GetPictureComment(PictureInfo pictureInfo)
        {
            PictureCommentDTO pictureCommentDTO = new PictureCommentDTO();
            PictureRequestDTO pictureRequestDTO = new PictureRequestDTO() { PictureID = pictureInfo.PictureID };

            try
            {
                pictureCommentDTO = API.GetObject<PictureCommentDTO, PictureRequestDTO>("GetPictureComment", pictureRequestDTO);
            }
            catch (Exception)
            {

                throw;
            }

            PictureComment pictureCommentDomain = DTOConverter.PictureCommentToDomain(pictureCommentDTO);
            return pictureCommentDomain;
        }

    }
}