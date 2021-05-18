using System.Collections.Generic;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using NSubstitute;
using NUnit.Framework;
using PW_BusinessLogicLayer;
using PW_DataAccessLayer.Interfaces;

namespace MoleTrackerWebsite_PW.UnitTests
{
    [TestFixture]
    public class UT_CreateNewCollectionController
    {
        private CreateNewCollectionController _uut;
        private ICreateNewCollectionDatabaseManager _createNewCollectionDatabaseManager;
        private Collection collection;

        [SetUp]
        public void Setup()
        {
            _uut = new CreateNewCollectionController();
            _createNewCollectionDatabaseManager = Substitute.For<ICreateNewCollectionDatabaseManager>();
            collection = new Collection();
        }

        [Test]
        public void HandleNewCollection_ReturnsPostNewCollectionInDatabaseManager()
        {
            //collection.Location = new LocationOnBody();
            //collection.CollectionName = "testnavn";
            //collection.CollectionID = 1;
            //collection.IsMarked = false;
            //collection.PatientID = 2;
            //collection.PictureList = new List<PictureInfo>();
            //_uut.HandleCreateNewCollection(collection).Returns(_createNewCollectionDatabaseManager.PostNewCollection(collection));
        }
    }
}