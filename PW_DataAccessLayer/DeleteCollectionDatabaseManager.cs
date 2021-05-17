using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class DeleteCollectionDatabaseManager : IDeleteCollectionDatabaseManager
    {
        private IAPIService API;

        public DeleteCollectionDatabaseManager()
        {
            API = APIFactory.GetAPI("");
        }

        public void DeleteCollection(Collection collection, PatientInfo patientInfo)
        {
            CollectionRequestDTO deleteCollectionRequest = new CollectionRequestDTO();
            deleteCollectionRequest.CollectionID = collection.CollectionID;
            deleteCollectionRequest.PatientID = patientInfo.PatientID;

            string result = API.PostObject<CollectionRequestDTO>("DeleteCollection", deleteCollectionRequest);
        }
    }
}