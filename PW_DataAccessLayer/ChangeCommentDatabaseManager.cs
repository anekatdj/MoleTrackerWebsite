﻿using System;
using System.Net;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Login;

namespace PW_DataAccessLayer
{
    public class ChangeCommentDatabaseManager : IChangeCommentDatabaseManager
    {
        PictureRequestDTO _pictureRequestDTO;
        private IAPIService API;

        public ChangeCommentDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);

            //API = new StubApiService();
            _pictureRequestDTO = new PictureRequestDTO();
        }


        public void PostNewPictureComment(PictureComment editedComment)
        {
            PictureCommentDTO _pictureCommentDTO = new PictureCommentDTO();

            _pictureCommentDTO.Comment = editedComment.Comment;
            _pictureCommentDTO.PictureID = editedComment.PictureID;

            API.PostObject<PictureCommentDTO>("NewPictureComment", _pictureCommentDTO);
        }
    }
}