using DataClasses.Domain.Collections;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IChangeCollectionNameController
    {
        public void HandleChangedName(ChangeCollectionName changeCollectionName);
    }
}