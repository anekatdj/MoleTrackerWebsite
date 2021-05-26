using System;
using System.Collections.Generic;
using System.Text;
using APIWebServiesConnector;
using DataClasses.Domain.Login;
using NSubstitute;
using NUnit.Framework;
using PW_DataAccessLayer;

namespace MoleTrackerWebsite_PW.UnitTests.DataAccessLayer
{
    [TestFixture]
    class Class1
    {
        private LoadContactInfoDatabaseManager _uut;
        private IAPIService API;

        [SetUp]
        public void SetUp()
        {
            API = Substitute.For<IAPIService>();
            _uut = new LoadContactInfoDatabaseManager("stub");
        }

        [Test]
        public void test1()
        {
            //var _patientInfo = new PatientInfo();
            //_patientInfo.MedicalPracticeID = 2;

            //var returnValue = _uut.GetContactInfo(_patientInfo);
            //Assert.That(returnValue.MedicalPracticeName, Is.EqualTo(""));
        }
    }
}
