using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using BusinessLogicLayer;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataClasses.Domain;
using Microsoft.AspNetCore.Components;
using MoleTrackerWebsite.Pages;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using NUnit.Framework;

namespace MedWebNUnitTest.PresentationLayerTest
{
    public class TestMedLoginPage
    {
        private MedLoginPage uut;
        private ILogInController logInController;
        private NavigationManager navManager;

        [SetUp]
        public void Setup()
        {
            logInController = Substitute.For<ILogInController>();
            navManager = Substitute.For<NavigationManager>();
            uut = new MedLoginPage();
            uut.LoginControllerProp = logInController;
            uut.NavManagerProp = navManager;
        }
        [Test]
        public void Login_Test_CallsLogin_on_LogInController()
        {
            //Arrange

            //Act
            uut.Login();

            uut.LogInInfo.Username = "";
            uut.LogInInfo.Password = "";

            //Assert
            logInController.Received(1).Login(Arg.Any<LoginInfoDomain>());
        }

        //Denne test virker kun hvis linje 131 "NavManagerProp.NavigateTo("/PatientOverviewPage");" udkommenteres, da vi ikke kan stubbe NavigateTo.
        [Test]
        public void Login_Test_TrueLogin()
        {
            //Arrange
            logInController.Login(Arg.Any<LoginInfoDomain>()).Returns(true);
            //navManager.NavigateTo("/PatientOverviewPage");
            //Act
            uut.Login();

            uut.LogInInfo.Username = "";
            uut.LogInInfo.Password = "";

            var returnValue = uut.LoginFailed;

            //Assert
            Assert.That(returnValue, Is.EqualTo(false));
        }
        [Test]
        public void Login_Test_FalseLogin()
        {
            //Arrange

            logInController.Login(Arg.Any<LoginInfoDomain>()).Returns(false);
            //Act

            uut.Login();
            uut.LogInInfo.Username = "";
            uut.LogInInfo.Password = "";

            var returnValue = uut.LoginFailed;

            //Arrange
            Assert.That(returnValue, Is.EqualTo(true));
        }
    }
}
