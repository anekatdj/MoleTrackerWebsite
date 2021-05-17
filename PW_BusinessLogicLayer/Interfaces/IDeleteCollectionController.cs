using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface IDeleteCollectionController
    {
        void HandleDeleteCollection(Collection collection, PatientInfo patientInfo);
    }
}