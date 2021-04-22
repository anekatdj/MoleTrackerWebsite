using APIWebServiesConnector;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using APIWebServiesConnector.APIStringFabrics;
using DataClasses.DTO;

namespace DataAccessLayer
{
    public class ViewCollectionDatabaseManager : IViewCollectionDatabaseManager
    {
        private IAPIService API;

        public ViewCollectionDatabaseManager()
        {
            API = APIFactory.GetAPI("");

        }

        public PictureDataDomain GetPictureData(PictureInfoDomain pictureInfoDomain)
        {
            PictureDataDTO pictureDataDTO = new PictureDataDTO();
            PictureRequestDTO pictureRequestDTO = new PictureRequestDTO() { PictureID = pictureInfoDomain.PictureID };

            try
            {
                pictureDataDTO = API.GetObject<PictureDataDTO, PictureRequestDTO>("GetMedicalPracticePatients", pictureRequestDTO);
            }
            catch (Exception)
            {

                throw;
            }

            PictureDataDomain pictureDataDomain = DTOConverter.PictureDataToDomain(pictureDataDTO);
            return pictureDataDomain;
        }
    }
}
