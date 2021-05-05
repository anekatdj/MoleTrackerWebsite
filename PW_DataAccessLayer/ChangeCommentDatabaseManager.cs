using System;
using System.Net;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;
using APIWebServiesConnector;
using DataClasses.Domain.Login;

namespace PW_DataAccessLayer
{
    public class ChangeCommentDatabaseManager : IChangeCommentDatabaseManager
    {
        private IAPIService API;

        public ChangeCommentDatabaseManager()
        {
            //API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());

            API = new StubApiService();
        }


        public void HandleChangedComment(PictureComment _pictureComment)
        {
            //PictureCommentDTO _pictureCommentDTO = new PictureCommentDTO();

            //_pictureCommentDTO.Comment = _pictureComment.Comment;
            //_pictureCommentDTO.PictureID = _pictureComment.PictureID;

            //try
            //{
            //    _pictureCommentDTO = API.GetObject<PictureCommentDTO>("GetPictureComment", loginInfoDTO);
            //}
            //catch (WebException e) when ((e.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            //{
            //    Console.WriteLine(e);
            //}

            //if (patientInfoDTO.CPR != null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}