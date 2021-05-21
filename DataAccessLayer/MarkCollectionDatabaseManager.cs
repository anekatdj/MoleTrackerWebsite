using System;
using System.Collections.Generic;
using System.Text;
using APIWebServiesConnector;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using DataClasses.DTO;

namespace DataAccessLayer
{
    public class MarkCollectionDatabaseManager : IMarkCollectionDatabaseManager
    {
        public IAPIService API { get; set; }

        public MarkCollectionDatabaseManager(string stub)
        {
            API = APIFactory.GetAPI(stub);
        }

        public void PostMarkedCollection(ChangeCollectionMarkingDomain _changeCollectionMarking)
        {
            ChangeCollectionMarkingDTO _changeCollectionMarkingDTO = new ChangeCollectionMarkingDTO();

            _changeCollectionMarkingDTO.CollectionID = _changeCollectionMarking.CollectionID;
            _changeCollectionMarkingDTO.IsMarked = _changeCollectionMarking.IsMarked;

            try
            {
                string ID = API.PostObject<ChangeCollectionMarkingDTO>("ChangeCollectionMarking", _changeCollectionMarkingDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
