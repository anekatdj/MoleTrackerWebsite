using System;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.Domain.Collections;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class MarkCollectionDatabaseManager : IMarkCollectionDatabaseManager
    {
        private IAPIService API;
        //public PatientDataDTO CurrentPatientData { get; set; }

        public MarkCollectionDatabaseManager(string APIType)
        {
            API = APIFactory.GetAPI(APIType);

            //API = new StubApiService();
        }

        public void PostMarkedCollection(ChangeCollectionMarking _changeCollectionMarking)
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