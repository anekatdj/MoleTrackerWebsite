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
                Assert.That(doctorContactInfo.OpeningHours.Count, Is.EqualTo(3));
                Assert.That(doctorContactInfo.OpeningHours[0], Is.EqualTo("mandag:10-15"));
                Assert.That(doctorContactInfo.OpeningHours[1], Is.EqualTo("tirsdag:10-15"));
                Assert.That(doctorContactInfo.OpeningHours[2], Is.EqualTo("onsdag:10-16"));
            });
        }

        [Test]
        public void MedicalPracticeID_1_ReturnsCorrectContactInfo()
        {
            _patientInfo.MedicalPracticeID = 1;
            var doctorContactInfo = _uut.HandleDoctorContactInfo(_patientInfo);

            Assert.Multiple(() =>
            {
                Assert.That(doctorContactInfo.MedicalPracticeName, Is.EqualTo("TetPractice"));
                Assert.That(doctorContactInfo.Adress, Is.EqualTo("Hangøgade 23 - 8000"));
                Assert.That(doctorContactInfo.PhoneNumber, Is.EqualTo("12345678"));
                Assert.That(doctorContactInfo.Website, Is.EqualTo("www.sundhed.dk"));
                Assert.That(doctorContactInfo.OpeningHours.Count, Is.EqualTo(7));
                Assert.That(doctorContactInfo.OpeningHours[0], Is.EqualTo("Mandag:10-15"));
                Assert.That(doctorContactInfo.OpeningHours[1], Is.EqualTo("Tirsdag:10-15"));
                Assert.That(doctorContactInfo.OpeningHours[2], Is.EqualTo("Onsdag:10-16"));
                Assert.That(doctorContactInfo.OpeningHours[3], Is.EqualTo("Torsdag:10-16"));
                Assert.That(doctorContactInfo.OpeningHours[4], Is.EqualTo("Fredag:10-16"));
                Assert.That(doctorContactInfo.OpeningHours[5], Is.EqualTo("Lørdag:10-11"));
                Assert.That(doctorContactInfo.OpeningHours[6], Is.EqualTo("Søndag:10-15"));
            });
        }
    }
}
