using APIWebServiesConnector;
using DataClasses.Domain.Login;
using DataClasses.DTO;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PW_DataAccessLayer;

namespace MoleTrackerWebsite_PW.UnitTests.DataAccessLayer
{
    [TestFixture]
    public class UT_LogInDatabaseManager
    {
        private LogInDatabaseManager _uut;
        private IAPIService API;
        [SetUp]
        public void Setup()
        {
            API = Substitute.For<IAPIService>();
            _uut = new LogInDatabaseManager("stub");
        }

        [Test]
        public void ValidateLogin_ReturnsNull()
        {
            var loginInfo = new LogInInfo();
            loginInfo.Username = "121212-1004";
            loginInfo.Password = "password";

            var patientInfo = new PatientInfoDTO();
            API.GetObject<PatientInfoDTO, LoginInfoDTO>("PatientLogin", Arg.Any<LoginInfoDTO>()).Returns(patientInfo);
        }
    }
}