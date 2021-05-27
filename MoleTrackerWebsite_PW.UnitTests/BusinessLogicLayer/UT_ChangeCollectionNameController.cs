using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain.Collections;
using NSubstitute;
using NUnit.Framework;
using PW_BusinessLogicLayer;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer.Interfaces;

namespace MoleTrackerWebsite_PW.UnitTests.BusinessLogicLayer
{
    class UT_ChangeCollectionNameController
    {
        private IChangeCollectionNameController _uut;
        private IChangeCollectionNameDatabaseManager _changeCollectionNameDatabaseManager;
        private Collection _collection;

        [SetUp]
        public void SetUp()
        {
            _uut = new ChangeCollectionNameController();
            _collection = Substitute.For<Collection>();
            _changeCollectionNameDatabaseManager = Substitute.For<IChangeCollectionNameDatabaseManager>();
        }

        [Test]
        public void HandleChangedName_ReturnsPostChangedCollectionNameInDatabaseManager()
        {
            _collection.CollectionID = 1;
            _collection.CollectionName = "testnavn";
            _uut.HandleChangedName(_collection);
        }
    }
}
