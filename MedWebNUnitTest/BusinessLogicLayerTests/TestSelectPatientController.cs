using System.Data;
using BusinessLogicLayer;
using DataAccessLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using NSubstitute;
using NUnit.Framework;

namespace MedWebNUnitTest.BusinessLogicLayerTests
{
    public class TestSelectPatientController
    {
        private ISelectPatientDatabaseManager selectPatientDatabaseManager;
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void DatabaseReceives_GetPatientData_Call()
        {
            //Arrange
            SelectPatientController uut = new SelectPatientController();
            ISelectPatientDatabaseManager db = Substitute.For<ISelectPatientDatabaseManager>();
            uut.SelectPatientDatabaseManager = db;

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
            db.Received(1).GetPatientData(patientInfo);
        }
        [Test]
        public void DatabaseReceives_GetPatientInfo_Call()
        {
            //Arrange
            SelectPatientController uut = new SelectPatientController();
            ISelectPatientDatabaseManager db = Substitute.For<ISelectPatientDatabaseManager>();
            uut.SelectPatientDatabaseManager = db;

            PatientInfoDomain patientInfo = new PatientInfoDomain()
            {
                CPR = "121212-1212",
                Email = "",
                Name = "Carl",
                PatientID = 1
            };


            //Act

            uut.GetPatientInfo(patientInfo);

            //Assert
            db.Received(1).GetPatientInfo(patientInfo);
        }
    }
}
