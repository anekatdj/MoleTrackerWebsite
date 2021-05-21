using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface IMarkCollectionController
    {
        void HandleMarking(ChangeCollectionMarkingDomain _changeCollectionMarking);
    }
}
