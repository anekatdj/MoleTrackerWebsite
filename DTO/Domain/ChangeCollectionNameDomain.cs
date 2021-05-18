using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class ChangeCollectionNameDomain
    {
        public int CollectionID { get; set; }
        public string CollectionName { get; set; }

        public ChangeCollectionNameDTO ToDTO()
        {
            ChangeCollectionNameDTO changeCollectionName = new ChangeCollectionNameDTO()
            {
                CollectionID = CollectionID,
                CollectionName = CollectionName
            };
            return changeCollectionName;
        }
    }
}
