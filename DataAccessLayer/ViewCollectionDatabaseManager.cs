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
                pictureDataDTO = API.GetObject<PictureDataDTO, PictureRequestDTO>("GetPictureData", pictureRequestDTO);
            }
            catch (Exception)
            {

                throw;
            }

            PictureDataDomain pictureDataDomain = DTOConverter.PictureDataToDomain(pictureDataDTO);
            return pictureDataDomain;
        }

        public PictureCommentDomain GetPictureComment(PictureInfoDomain pictureInfo)
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

            PictureCommentDomain pictureCommentDomain = DTOConverter.PictureCommentToDomain(pictureCommentDTO);
            return pictureCommentDomain;
        }

        public void PostNewPictureComment(PictureCommentDomain editedComment)
        {
            PictureCommentDTO pictureCommentDTO = editedComment.ToDTO();
            try
            {
                API.PostObject<PictureCommentDTO>("NewPictureComment", pictureCommentDTO);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
