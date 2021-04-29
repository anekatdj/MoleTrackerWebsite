using System;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.DataObjects.DTO;
using DataClasses.Domain;
using DataClasses.DTO;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReturnsExtensions;
using NUnit.Framework;

namespace MedWebNUnitTest.DataAccessLayerTests
{
    public class TestLogInDatabaseManager
    {
        private LogInDatabaseManager uut;
        private IAPIService fakeAPI;

        [SetUp]
        public void Setup()
        {
            fakeAPI = Substitute.For<IAPIService>();
            uut = new LogInDatabaseManager("stub");
            uut.API = fakeAPI;
        }

        [Test]
        public void CheckIf_VerifyLoginWithAPI_ReturnsNotNull()
        {
            var loginInfo = new LoginInfoDomain();
            loginInfo.Username = "12345";
            loginInfo.Password = "12345";

            var fakeDoctorInfoDTO = new DoctorInfoDTO();
            fakeDoctorInfoDTO.DoctorID = 1;

            LoginInfoDTO loginDTO = new LoginInfoDTO();
            fakeAPI.GetObject<DoctorInfoDTO, LoginInfoDTO>("MedLogin", Arg.Any<LoginInfoDTO>()).Returns(fakeDoctorInfoDTO);

            var returnValue= uut.VerifyLoginWithAPI(loginInfo);


            Assert.That(returnValue, Is.Not.Null);
        }    
        [Test]
        public void CheckIf_VerifyLoginWithAPI_ReturnsNull()
        {
            var loginInfo = new LoginInfoDomain();
            loginInfo.Username = "12345";
            loginInfo.Password = "12345";

            fakeAPI.GetObject<DoctorInfoDTO, LoginInfoDTO>("MedLogin", Arg.Any<LoginInfoDTO>()).Throws<Exception>();

            Assert.That(uut.VerifyLoginWithAPI(loginInfo), Is.Null);

        }
    }
}
