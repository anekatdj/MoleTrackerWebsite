using System;
using System.Collections.Generic;
using APIWebServiesConnector;
using DataAccessLayer;
using DataClasses.DataObjects.DTO;
using DataClasses.DTO;
using NSubstitute;
using NSubstitute.Core.Arguments;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;

namespace MedWebNUnitTest.DataAccessLayerTests
{
    public class TestLoadPatientsDatabaseManager
    {
        private LoadPatientsDatabaseManager uut;
        private IAPIService fakeAPI;

        [SetUp]
        public void Setup()
        {
            fakeAPI = Substitute.For<IAPIService>();
            uut = new LoadPatientsDatabaseManager("stub");
            uut.API = fakeAPI;
        }

        [Test]
        public void GetMedicalPracticePatients_ReturnsMedicalPracticePatientDomain_WithMedicalPracticeID_123()
        {
            var medicalPractice = new MedicalPracticePatientsDTO();
            medicalPractice.MedicalPracticeID = 123;
            medicalPractice.PatientList = new List<PatientInfoDTO>();

            fakeAPI.GetObject<MedicalPracticePatientsDTO, SessionInfoDTO>("MedicalPracticePatients",  Arg.Any<SessionInfoDTO>()).Returns(medicalPractice);

            var returnValue = uut.GetMedicalPracticePatients();

            var medicalPracticeID = returnValue.MedicalPracticeID;

            Assert.That(returnValue, Is.Not.Null);
            Assert.That(medicalPracticeID, Is.EqualTo(123));
        }
        [Test]
        public void GetMedicalPracticePatients_ThrowsException_WhenAPIFails()
        {


            fakeAPI.GetObject<MedicalPracticePatientsDTO, SessionInfoDTO>("MedicalPracticePatients",
                Arg.Any<SessionInfoDTO>()).Throws<Exception>();

            Assert.Throws<Exception>(() => uut.GetMedicalPracticePatients());
        }
    }
    
}
