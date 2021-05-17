﻿using System;
using APIWebServiesConnector;
using DataClasses.Domain.Collections;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class MarkCollectionDatabaseManager : IMarkCollectionDatabaseManager
    {
        private IAPIService API;
        //public PatientDataDTO CurrentPatientData { get; set; }

        public MarkCollectionDatabaseManager()
        {
            API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());

            //API = new StubApiService();
        }

        public void PostMarkedCollection(ChangeCollectionMarking _changeCollectionMarking) //TODO Skal det her være void?
        {
            ChangeCollectionMarkingDTO _changeCollectionMarkingDTO = new ChangeCollectionMarkingDTO();

            _changeCollectionMarkingDTO.CollectionID = _changeCollectionMarking.CollectionID;
            _changeCollectionMarkingDTO.IsMarked = _changeCollectionMarking.IsMarked;

            try
            {
                string ID = API.PostObject<ChangeCollectionMarkingDTO>("PutNewCollectionMark", _changeCollectionMarkingDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //public void UpdateCollection(CollectionDTO UpdatedCollection)
        //{
        //    CollectionDTO OldCollectionDTO = CurrentPatientData.CollectionList.First(i => i.CollectionID == UpdatedCollection.CollectionID);

        //    int indexPosition = CurrentPatientData.CollectionList.IndexOf(OldCollectionDTO);

        //    CurrentPatientData.CollectionList[indexPosition] = UpdatedCollection;
        //}
    }
}