using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.Domain.Login;
using NSubstitute;
using NUnit.Framework;
using PW_BusinessLogicLayer;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer.Interfaces;

namespace MoleTrackerWebsite_PW.UnitTests.BusinessLogicLayer
{
    class UT_LoadContactInformationController
    {
        private PatientInfo _patientInfo;
        private ILoadContactInformationController _uut;
        private ILoadContactInfoDatabaseManager _loadContactInfoDatabaseManager;

        [SetUp]
        public void SetUp()
        {
            _patientInfo = Substitute.For<PatientInfo>();
            _loadContactInfoDatabaseManager = Substitute.For<ILoadContactInfoDatabaseManager>();
            _uut = new LoadContactInformationController();
        }

        [Test]
        public void HandleDoctorConctactInfo_ReturnsGetContactInfoInDatabaseManager()
        {
            _patientInfo.MedicalPracticeID = 2;
            _uut.HandleDoctorContactInfo(_patientInfo).Returns(_loadContactInfoDatabaseManager.GetContactInfo(_patientInfo));
        }

        [Test]
        public void MedicalPracticeID_2_ReturnsCorrectContactInfo()
        {
            _patientInfo.MedicalPracticeID = 2;
            var doctorContactInfo = _uut.HandleDoctorContactInfo(_patientInfo);

            Assert.Multiple(() =>
            {
                Assert.That(doctorContactInfo.MedicalPracticeName, Is.EqualTo("hejs"));
                Assert.That(doctorContactInfo.Adress, Is.EqualTo("Æblegade 23- 1234"));
                Assert.That(doctorContactInfo.PhoneNumber, Is.EqualTo("87654321"));
                Assert.That(doctorContactInfo.Website, Is.EqualTo("www.google.dk"));
            });
        }
    }
}
