using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataClasses.Domain;
using Microsoft.AspNetCore.Components;
using MoleTrackerWebsite.Pages;
using NSubstitute;
using NUnit.Framework;

namespace MedWebNUnitTest.PresentationLayerTest
{
    public class TestPatientOverviewPage
    {
        private PatientOverviewPage uut;
        private ILoadPatientsController loadPatientsController;
        private NavigationManager navManager;

        [SetUp]
        public void Setup()
        {
            loadPatientsController = Substitute.For<ILoadPatientsController>();
            navManager = Substitute.For<NavigationManager>();
            //uut = new PatientOverviewPage();
            //uut.LoadPatientsControllerProp = loadPatientsController;
            //uut.NavManagerProp = navManager;
        }

        //[Test]
        //public void MedicalPracticePatientList_IsEqualTo()
        //{
        //    //Arrange
        //    var fakePatientList = new List<PatientInfoDomain>();

        //    PatientInfoDomain patientA = new PatientInfoDomain();
        //    patientA.Name = "Børge";
        //    patientA.CPR = "121212-7611";
        //    PatientInfoDomain patientB = new PatientInfoDomain();
        //    patientB.Name = "Dorthe";
        //    patientB.CPR = "231196-5422";

        //    fakePatientList.Add(patientA);
        //    fakePatientList.Add(patientB);

        //    uut = new PatientOverviewPage();
        //    uut.LoadPatientsControllerProp = loadPatientsController;
        //    uut.NavManagerProp = navManager;
            
        //    loadPatientsController.LoadPatientList().Returns(fakePatientList);
        //    //Act
           
        //    //Assert

        //    Assert.That(uut.MedicalPracticePatientList, Is.EqualTo(fakePatientList));
        //}
    }
}
