using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;
using DataClasses.Domain.Login;
using DataClasses.DTO;
using NSubstitute;
using NUnit.Framework;
using PW_BusinessLogicLayer;
using PW_DataAccessLayer.Interfaces;

namespace MoleTrackerWebsite_PW.UnitTests.BusinessLogicLayer
{ 
    public class UT_LoginController
    {
        private LogInController _uut;
        private LogInInfo _logInInfo;
        private PatientInfo _patientInfo;
        private PatientInfoDTO _patientInfoDto;
        private ILogInDatabaseManager logInDatabaseManager;

        [SetUp]
        public void Setup()
        {
            _uut = new LogInController();
            _logInInfo = Substitute.For<LogInInfo>();
            _patientInfo = Substitute.For<PatientInfo>();
            _patientInfoDto = Substitute.For<PatientInfoDTO>();
            logInDatabaseManager = Substitute.For<ILogInDatabaseManager>();
        }

        [Test]
        public void HandleLogin_ReturnsValidateLoginInDatabaseManager()
        {
            _logInInfo.Username = "12345";
            _logInInfo.Password = "12345";
            _uut.HandleLogin(_logInInfo).Returns(logInDatabaseManager.ValidateLogin(_logInInfo));
        }

        [Test]
        public void HandlePatientInfo_ReturnsGetPatientInfoInDatabaseManager()
        {
            _logInInfo.Username = "12345";
            _logInInfo.Password = "12345";
            _uut.HandleLogin(_logInInfo);
            _uut.HandlePatientInfo().Returns(logInDatabaseManager.GetPatientInfo());
        }

        [Test]
        public void ExistingUser_ReturnsTrue()
        {
            _logInInfo.Username = "12345";
            _logInInfo.Password = "12345";

            Assert.That(_uut.HandleLogin(_logInInfo), Is.EqualTo(true));
        }

        [Test]
        public void NotExcistingUser_ReturnsFalse()
        {
            _logInInfo.Username = "12345";
            _logInInfo.Password = "54321";

            Assert.That(_uut.HandleLogin(_logInInfo), Is.EqualTo(false));
        }

        [Test] //TODO Den var udkommenteret, men failer ikke? 
        public void ValidLogIn_ReturnsPatientInfo()
        {
            _logInInfo.Username = "12345";
            _logInInfo.Password = "12345";
            _uut.HandleLogin(_logInInfo);

            Assert.Multiple(() =>
            {
                Assert.That(_uut.HandlePatientInfo().CPR, Is.EqualTo(_logInInfo.Username));
                Assert.That(_uut.HandlePatientInfo().Name, Is.EqualTo("Test Bruger 12345"));
                Assert.That(_uut.HandlePatientInfo().Gender, Is.EqualTo("B"));
                Assert.That(_uut.HandlePatientInfo().Email, Is.EqualTo("12345@mail.com"));
            });
        }
    }
}
