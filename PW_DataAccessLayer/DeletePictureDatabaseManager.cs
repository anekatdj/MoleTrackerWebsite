using APIWebServiesConnector;
using DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    class DeletePictureDatabaseManager : IDeletePictureDatabaseManager
    {
        private IAPIService API;

        public DeletePictureDatabaseManager()
        {
            API = APIFactory.GetAPI("");
        }

        public void DeletePicture()
        {

        }
    }
}