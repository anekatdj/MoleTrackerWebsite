using BusinessLogicLayer;
using DataClasses.Domain;
using NSubstitute;
using NSubstitute.Core;
using NUnit.Framework;

namespace MedWebNUnitTest.BusinessLogicLayerTests
{
    public class TestLogInController
    {
        private LogInController uut;
        [SetUp]
        public void Setup()
        {
            uut = new LogInController();
        }

        [Test]
        public void CheckIf_LoginReturnsTrue_WhenloginData_IsValid()
        {
            LoginInfoDomain loginData = new LoginInfoDomain();
            loginData.Username = "12345";
            loginData.Password = "12345";

            Assert.IsTrue(uut.Login(loginData));
        }
    }
}