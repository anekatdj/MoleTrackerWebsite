using System.Collections.Generic;
using APIWebServiesConnector;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using NSubstitute;
using NUnit.Framework;
using PW_DataAccessLayer;

namespace MoleTrackerWebsite_PW.UnitTests.DataAccessLayer
{
    [TestFixture]
    public class UT_CreateNewCollectionDatabaseManager
    {
        private CreateNewCollectionDatabaseManager _uut;
        private IAPIService API;
        [SetUp]
        public void Setup()
        {
            API = Substitute.For<IAPIService>();
            _uut = new CreateNewCollectionDatabaseManager("stub");
        }

        [Test]
        public void PostNewCollection_CollectionIDIsNotNull()
        {
            Collection collection = new Collection();
            collection.CollectionID = 1;
            collection.CollectionName = "Test";
            collection.Location = new LocationOnBody();
            collection.IsMarked = false;
            collection.PatientID = 2;
            collection.PictureList = new List<PictureInfo>();
            _uut.PostNewCollection(collection);
            Assert.That(collection.CollectionID, Is.Not.Null);
        }



    }
}