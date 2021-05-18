using System;
using System.Collections.Generic;
using System.Text;
using APIWebServiesConnector;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using DataClasses.DTO;

namespace DataAccessLayer
{
    public class ChangeCollectionNameDatabaseManager : IChangeCollectionNameDatabaseManager
    {
        private ChangeCollectionNameDTO changeCollectionNameDTO;
        public IAPIService API { get; set; }

        public ChangeCollectionNameDatabaseManager(string stub)
        {
            API = APIFactory.GetAPI(stub);
        }

        public void ChangeCollectionName(ChangeCollectionNameDomain changeCollectionName)
        {
            changeCollectionNameDTO = changeCollectionName.ToDTO();
            try
            {
                var result = API.PostObject<ChangeCollectionNameDTO>("ChangeCollectionName", changeCollectionNameDTO);
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
