using System;
using System.Collections.Generic;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;
using NSubstitute;
using NUnit.Framework;
using PW_BusinessLogicLayer;
using PW_DataAccessLayer.Interfaces;

namespace MoleTrackerWebsite_PW.UnitTests.BusinessLogicLayer
{
    [TestFixture]
    public class UT_ViewCollectionController
    {
        private ViewCollectionController _uut;
        private IViewCollectionDatabaseManager _viewCollectionDatabaseManager;
        private ICreateNewCollectionDatabaseManager _createNewCollectionDatabaseManager;
        private Collection collection;
        private PictureInfo pictureInfo;

        [SetUp]
        public void Setup()
        {
            _uut = new ViewCollectionController();
            _viewCollectionDatabaseManager = Substitute.For<IViewCollectionDatabaseManager>();
            _createNewCollectionDatabaseManager = Substitute.For<ICreateNewCollectionDatabaseManager>();
            collection = new Collection();
            pictureInfo = new PictureInfo();

            collection.Location = new LocationOnBody();
            collection.CollectionName = "testnavn";
            collection.CollectionID = 1;
            collection.IsMarked = false;
            collection.PatientID = 2;
            collection.PictureList = new List<PictureInfo>();

            _createNewCollectionDatabaseManager.PostNewCollection(collection);
        }

        //[Test]
        //public void GetCollectionFromDB_CallsGetExistingCollection_InViewCollectionDB()
        //{
        //    _uut.GetCollectionFromDB(collection);
        //    _viewCollectionDatabaseManager.Received(1).GetExistingCollection(collection);
        //}

        //[Test]
        //public void HandleCollection_ReturnsGetPictures_FromViewCollectionDB()
        //{
        //    pictureInfo.CollectionID = 1;
        //    pictureInfo.DateOfUpload = DateTime.Now;
        //    pictureInfo.PictureID = 1;
            
        //    _uut.HandleCollection(pictureInfo).Returns(_viewCollectionDatabaseManager.GetPictures(pictureInfo));
        //}
    }
}