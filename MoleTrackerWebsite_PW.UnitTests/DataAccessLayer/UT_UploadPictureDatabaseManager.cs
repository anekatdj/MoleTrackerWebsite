using APIWebServiesConnector;
using DataClasses.Domain.Collections;
using NSubstitute;
using NUnit.Framework;
using PW_DataAccessLayer;

namespace MoleTrackerWebsite_PW.UnitTests.DataAccessLayer
{
    [TestFixture]
    public class UT_UploadPictureDatabaseManager
    {
        private UploadPictureDatabaseManager _uut;
        private Collection collection;
        private IAPIService API;
        [SetUp]
        public void Setup()
        {
            API = Substitute.For<IAPIService>();
            _uut = new UploadPictureDatabaseManager("stub", collection);
        }

        [Test]
        public void UploadPictureToDatabase_IsTrue()
        {

        }
    }
}