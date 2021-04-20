using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class ViewCollectionController : IViewCollectionController
    {
        private IViewCollectionDatabaseManager viewCollectionDatabaseManager;
        public ViewCollectionController()
        {
            viewCollectionDatabaseManager = new ViewCollectionDatabaseManager();
        }
        public PictureDataDomain GetPictureData(PictureInfoDomain pictureInfo)
        {
            return viewCollectionDatabaseManager.GetPictureData(pictureInfo);
        }
    }
}
