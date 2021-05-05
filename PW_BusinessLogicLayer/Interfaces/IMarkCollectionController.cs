using DataClasses.Domain.Collections;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IMarkCollectionController
    {
        void HandleMarking(ChangeCollectionMarking _changeCollectionMarking);
    }
}