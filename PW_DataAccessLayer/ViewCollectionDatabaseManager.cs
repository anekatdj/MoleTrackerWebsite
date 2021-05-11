using System;
using APIWebServiesConnector;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class ViewCollectionDatabaseManager : IViewCollectionDatabaseManager
    {

        private IAPIService API;

        public ViewCollectionDatabaseManager()
        {
            //API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());

            API = new StubApiService();
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

    }
}