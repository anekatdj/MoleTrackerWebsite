using System.Collections.Generic;
using BusinessLogicLayer;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;
using NSubstitute;
using NUnit.Framework;

namespace MedWebNUnitTest.BusinessLogicLayerTests
{
    public class TestLoadPatientsController
    {
        private LoadPatients uut;
        private ILoadPatientsDatabaseManager fakeLoadPatientsDatabaseManager;

        [SetUp]
        public void Setup()
        {
            uut = new LoadPatients();
            fakeLoadPatientsDatabaseManager = Substitute.For<ILoadPatientsDatabaseManager>();
            uut.LoadPatientsDatabaseManager = fakeLoadPatientsDatabaseManager;
        }

        [Test]
        public void CheckIf_LoadPatientList_ReturnsListOfPatients()
        {
            MedicalPracticePatientsDomain medicalPractice = new MedicalPracticePatientsDomain();
            List<PatientInfoDomain> patientList = new List<PatientInfoDomain>();
            medicalPractice.MedicalPracticeID = 1;
            PatientInfoDomain patientA = new PatientInfoDomain();
            patientA.Name = "Børge";
            patientA.CPR = "121212-7611";
            PatientInfoDomain patientB = new PatientInfoDomain();
            patientB.Name = "Dorthe";
            patientB.CPR = "231196-5422";
            patientList.Add(patientA);
            patientList.Add(patientB);
            medicalPractice.PatientList = patientList;

            fakeLoadPatientsDatabaseManager.GetMedicalPracticePatients().Returns(medicalPractice);


            Assert.That(uut.LoadPatientList(), Is.EqualTo(patientList));
        }
    }
}
