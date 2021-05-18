using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;

namespace PW_BusinessLogicLayer
{
    public class DeleteCollectionController : IDeleteCollectionController
    {
        public void HandleDeleteCollection(Collection collection, PatientInfo patientInfo)
        {
            DeleteCollectionDatabaseManager deleteCollection = new DeleteCollectionDatabaseManager("");

            deleteCollection.DeleteCollection(collection, patientInfo);
        }
    }
}