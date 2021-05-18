using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class DeletePictureDatabaseManager : IDeletePictureDatabaseManager
    {
        private IAPIService API;

        public DeletePictureDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);
        }

        public void DeletePicture(PictureInfo pictureInfo)
        {
            PictureRequestDTO pictureRequest = new PictureRequestDTO();
            pictureRequest.PictureID = pictureInfo.PictureID;

            string result = API.PostObject<PictureRequestDTO>("DeletePicture", pictureRequest);
        }
    }
}