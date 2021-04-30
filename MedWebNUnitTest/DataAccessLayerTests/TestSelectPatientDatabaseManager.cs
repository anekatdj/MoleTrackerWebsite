using System;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;

namespace MedWebNUnitTest.DataAccessLayerTests
{
    public class TestSelectPatientDatabaseManager
    {
        private ISelectPatientDatabaseManager uut;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //Arrange
            uut = new SelectPatientDatabaseManager();
            PatientInfoDomain patientInfo = new PatientInfoDomain()
            {
                CPR = "121212-1212",
                Email = "",
                Name = "Carl",
                PatientID = 1
            };

            //Act
            uut.GetPatientData(patientInfo);

            //Assert
            Assert.Pass();
        }
    }
}
