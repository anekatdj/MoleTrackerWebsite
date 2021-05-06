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
        PictureRequestDTO _pictureRequestDTO;
        private IAPIService API;

        public ChangeCommentDatabaseManager()
        {
            //API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());
            
            API = new StubApiService();
            _pictureRequestDTO = new PictureRequestDTO();
        }


        public void HandleChangedComment(PictureComment pictureComment)
        {
            PictureCommentDTO _pictureCommentDTO = new PictureCommentDTO();

            _pictureCommentDTO.Comment = pictureComment.Comment;
            _pictureCommentDTO.PictureID = pictureComment.PictureID;

            try
            {
                _pictureRequestDTO = API.GetObject<PictureRequestDTO, PictureCommentDTO>("GetPictureComment", _pictureCommentDTO);
            }
            catch (WebException e) when ((e.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine(e);
            }
        }
    }
}