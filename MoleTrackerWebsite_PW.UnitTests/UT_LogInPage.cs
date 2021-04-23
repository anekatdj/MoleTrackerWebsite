using System;
using System.Collections.Generic;
using System.Text;
using Bunit;
using Bunit.TestDoubles;
using Microsoft.AspNetCore.Components;
using MoleTrackerWebsite.Pages;
using NSubstitute;
using NUnit.Framework;
using TestContext = Bunit.TestContext;


namespace MoleTrackerWebsite_PW.UnitTests
{
    public class UT_LogInPage
    {
        private LogInPage _logInPage;

        private NavigationManager _navigation;
        //private PatientLogInPage _patientLogInPage;

        [SetUp]
        public void Setup()
        {
            _logInPage = new LogInPage();
            //_logInPage = Substitute.For<LogInPage>();
            _navigation = Substitute.For<NavigationManager>();
        }

        [Test]
        public void CallNavigateToPatientLoginPageMethod()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act
            var cut = ctx.RenderComponent<LogInPage>();

            cut.Find("#PatLogInButton").Click();

            //Assert
            //TODO Hvad skal der stå her?

            //string url = "/patientLogin";

            //_navigation.NavigateTo(Arg.Is<string>(str => str.Contains(url)));


            /*_navigate.OutputLine(Arg.Is<string>(str => str.Contains($"{power}")))*/;



            //_logInPage.NavigateToPatientLogInPage();

            //_logInPage.Received(1).NavigateToPatientLogInPage();
            //_navigation.Received(1).NavigateTo("/patientLogin");

            //_logInPage.Received(1).NavigateToPatientLogInPage();
            //_patientLogInPage.Received(1).
        }

        [Test]
        public void CallNavigateToMedLoginPageMethod()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act
            var cut = ctx.RenderComponent<LogInPage>();

            cut.Find("#MedLogInButton").Click();

            //Assert
            
        }
    }
}
