using System;
using DataClasses.Domain.Collections;
using DataClasses.Domain.MISC;
using DataClasses.Domain.Picture;
using DataClasses.DTO;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class CreateNewCollectionController : ICreateNewCollectionController
    {
        public bool New { get; set; } = false;
        private ICreateNewCollectionDatabaseManager _createNewCollectionDatabaseManager;
        private PatientData _patientData;

        public CreateNewCollectionController()
        {
            _createNewCollectionDatabaseManager = new CreateNewCollectionDatabaseManager("");
            _patientData = new PatientData();
        }

        public int HandleCreateNewCollection(Collection collection)
        {
            //collection.Location = new LocationOnBody();
            //collection.CollectionID = _createNewCollectionDatabaseManager.PostNewCollection(collection);
            return _createNewCollectionDatabaseManager.PostNewCollection(collection);
            //_createNewCollectionDatabaseManager.CurrentPatientData.CollectionList.Add(collection);
        }
    }
}