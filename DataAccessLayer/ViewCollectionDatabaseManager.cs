using APIWebServiesConnector;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.CollectionDTO;
using DataClasses.Domain;
using DataClasses.PictureDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class ViewCollectionDatabaseManager : IViewCollectionDatabaseManager
    {
        private IAPIService API;

        public ViewCollectionDatabaseManager()
        {
            API = new StubApiService();
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
            PictureDataDomain pictureDataDomain = pictureDataDTO.ToDomain();
            return pictureDataDomain;
        }
    }
}
