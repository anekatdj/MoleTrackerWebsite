using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataAccessLayerInterfaces
{
    public interface IViewCollectionDatabaseManager
    {
        PictureDataDomain GetPictureData(PictureInfoDomain pictureInfoDomain);
        PictureCommentDomain GetPictureComment(PictureInfoDomain pictureInfo);
    }
}
