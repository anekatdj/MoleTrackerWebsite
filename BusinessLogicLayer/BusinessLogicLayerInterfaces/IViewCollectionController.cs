using DataClasses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface IViewCollectionController
    {
        CollectionDomain SelectedCollection { get; set; }
        PictureDataDomain GetPictureData(PictureInfoDomain pictureInfo);
    }
}
