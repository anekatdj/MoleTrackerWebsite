﻿using System;
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

        public UploadPictureDatabaseManager(string APIType, Collection collection)
        {
            API = APIFactory.GetAPI(APIType);
            Collection = collection;
        }

        public void UploadPictureToDatabase(byte[] newDataBytes, PictureInfo pictureInfo)
        {
            PostPictureDTO NewPostPicture = new PostPictureDTO();

            NewPostPicture.Comment = new PictureCommentDTO();
            NewPostPicture.Info = pictureInfo.ToDTO();
            NewPostPicture.Data = new PictureDataDTO();

            NewPostPicture.Data.PictureData = newDataBytes;

            NewPostPicture.Comment.Comment = "";

            API.PostObject<PostPictureDTO>("NewPicture", NewPostPicture);
        }
    }
}