using BusinessLogicLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using NSubstitute;
using NSubstitute.Core;
using NSubstitute.ReturnsExtensions;
using NUnit.Framework;

namespace MedWebNUnitTest.BusinessLogicLayerTests
{
    public class TestLogInController
    {
        private LogInController uut;
        private ILogInDatabaseManager fakeLogInDatabaseManager;

        [SetUp]
        public void Setup()
        {
            uut = new LogInController();
            fakeLogInDatabaseManager = Substitute.For<ILogInDatabaseManager>();
            uut.LogInDatabaseManager = fakeLogInDatabaseManager;
        }

        [Test]
        public void CheckIf_LoginReturnsTrue_WhenloginData_IsValid()
        {
            LoginInfoDomain loginData = new LoginInfoDomain();
            loginData.Username = "12345";
            loginData.Password = "12345";

            fakeLogInDatabaseManager.VerifyLoginWithAPI(loginData).Returns(new DoctorInfoDomain());

            Assert.IsTrue(uut.Login(loginData));
        }        
        [Test]
        public void CheckIf_LoginReturnsFalse_WhenloginData_IsInvalid()
        {
            LoginInfoDomain loginData = new LoginInfoDomain();
            loginData.Username = "54321";
            loginData.Password = "54321";

            fakeLogInDatabaseManager.VerifyLoginWithAPI(loginData).ReturnsNull();

            Assert.IsFalse(uut.Login(loginData));
        }
    }
}