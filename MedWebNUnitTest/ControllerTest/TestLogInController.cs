using BusinessLogicLayer;
using DataClasses.Domain;
using NUnit.Framework;

namespace MedWebNUnitTest
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
        public void Test1()
        {
            LoginInfoDomain loginInfoDomain = new LoginInfoDomain();
            uut.login(loginInfoDomain);
            Assert.Pass();
        }
    }
}