using DataClasses.Domain.Collections;
using DataClasses.DTO;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ICreateNewCollectionController
    {
        void HandleCreateNewCollection(Collection collection);
        //void HandleLoadCollection(Collection collection);
    }
}