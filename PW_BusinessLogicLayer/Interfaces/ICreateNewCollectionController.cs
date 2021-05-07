using DataClasses.Domain.Collections;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ICreateNewCollectionController
    {
        void HandleCreateNewCollection(Collection collection);
    }
}