using DataClasses.Domain.Collections;
using DataClasses.DTO;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ICreateNewCollectionController
    {
        public bool NewOrOld { get; set; }
        int HandleCreateNewCollection(Collection collection);
        //void HandleLoadCollection(Collection collection);
    }
}