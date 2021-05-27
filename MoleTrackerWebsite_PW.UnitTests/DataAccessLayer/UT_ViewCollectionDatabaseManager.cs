using APIWebServiesConnector;
using NSubstitute;
using NUnit.Framework;
using PW_DataAccessLayer;

namespace MoleTrackerWebsite_PW.UnitTests.DataAccessLayer
{
    [TestFixture]
    public class UT_ViewCollectionDatabaseManager
    {
        private ViewCollectionDatabaseManager _uut;
        private IAPIService API;
        [SetUp]
        public void Setup()
        {
            API = Substitute.For<IAPIService>();
            _uut = new ViewCollectionDatabaseManager("stub");
        }
    }
}