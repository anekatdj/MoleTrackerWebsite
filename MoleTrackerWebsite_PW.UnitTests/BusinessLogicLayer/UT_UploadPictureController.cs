using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain.Picture;
using NSubstitute;
using NUnit.Framework;
using PW_BusinessLogicLayer;

namespace MoleTrackerWebsite_PW.UnitTests.BusinessLogicLayer
{
    class UT_UploadPictureController
    {
        private PictureInfo _pictureInfo;
        private UploadPictureController _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new UploadPictureController();
            _pictureInfo = Substitute.For<PictureInfo>();

        }

        [Test]
        public void UploadPicture_ReturnsUploadPictureToDatabaseInDatabaseManager()
        {

        }

    }
}
