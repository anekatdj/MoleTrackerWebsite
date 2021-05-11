using DataClasses.Domain;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class ViewCollectionController : IViewCollectionController
    {
        private IViewCollectionDatabaseManager viewCollectionDatabaseManager;

        public ViewCollectionController()
        {
            viewCollectionDatabaseManager = new ViewCollectionDatabaseManager();
        }

        public PictureData HandleCollection(PictureInfo pictureInfo)
        {
            return viewCollectionDatabaseManager.GetCollection(pictureInfo);
        }
    }
}