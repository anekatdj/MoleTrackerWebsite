using System;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class UploadPictureDatabaseManager : IUploadPictureDatabaseManager
    {
        private IAPIService API;
        public Collection Collection { get; set; }

        public UploadPictureDatabaseManager(Collection collection)
        {
            API = APIFactory.GetAPI("");
            Collection = collection;
        }

        public void UploadPictureToDatabase(byte[] newDataBytes, PictureInfo pictureInfo)
        {
            PostPictureDTO NewPostPicture = new PostPictureDTO();

            NewPostPicture.Comment = new PictureCommentDTO();
            //NewPostPicture.Comment.LoginType = "P";
            NewPostPicture.Info = pictureInfo.ToDTO();
            //NewPostPicture.Info.LoginType = "P";
            NewPostPicture.Data = new PictureDataDTO();
            //NewPostPicture.Data.LoginType = "P";

            NewPostPicture.Data.PictureData = newDataBytes;

            NewPostPicture.Comment.Comment = "";

            try
            {
                API.PostObject<PostPictureDTO>("NewPicture", NewPostPicture);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }
    }
}