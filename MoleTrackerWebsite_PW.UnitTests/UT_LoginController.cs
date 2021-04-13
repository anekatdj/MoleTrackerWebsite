using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain;
using DataClasses.DTO.LoginDTOS;
using NSubstitute;
using NUnit.Framework;
using PW_BusinessLogicLayer;

namespace MoleTrackerWebsite_PW.UnitTests
{ 
    public class UT_LoginController
    {
        private LogInController _uut;
        private LogInInfo _logInInfo;
        private PatientInfoDTO _patientInfoDto;

        [SetUp]
        public void Setup()
        {
            _uut = new LogInController();
            _logInInfo = Substitute.For<LogInInfo>();
            _patientInfoDto = Substitute.For<PatientInfoDTO>();
        }

        [Test]
        public void test1()
        {
            //_logInInfo.Username = "1234567890";
            //_patientInfoDto.CPR = "1234567890";

            //Assert.That(_uut.HandleLogin(_logInInfo), Is.EqualTo(true));
        }
    }
}
