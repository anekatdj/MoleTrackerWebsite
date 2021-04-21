using System;
using System.Collections.Generic;
using System.Text;
using Bunit;
using MoleTrackerWebsite.Pages;
using NSubstitute;
using NUnit.Framework;
using TestContext = Bunit.TestContext;


namespace MoleTrackerWebsite_PW.UnitTests
{
    public class UT_LogInPage
    {
        private LogInPage _logInPage;
        //private PatientLogInPage _patientLogInPage;

        [SetUp]
        public void Setup()
        {
            _logInPage = Substitute.For<LogInPage>();
            //_uut = new LogInPage();
            //_patientLogInPage = Substitute.For<PatientLogInPage>(); //Ups man må kun med interfaces
        }

        [Test]
        public void CallNavigateToPatientLoginPageMethod()
        {
            using var ctx = new TestContext();

            var cut = ctx.RenderComponent<LogInPage>();

            cut.Find("button").Click();

            //_logInPage.Received(1).NavigateToPatientLogInPage();
            //_patientLogInPage.Received(1).
        }
    }
}
