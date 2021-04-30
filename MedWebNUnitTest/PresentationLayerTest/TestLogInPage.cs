using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;
using MoleTrackerWebsite.Pages;
using NSubstitute;
using NUnit.Framework;

namespace MedWebNUnitTest.PresentationLayerTest
{
    public class TestLogInPage
    {
        private LogInPage uut;
        private MedLoginPage medLoginPage;
        [SetUp]
        public void Setup()
        {
            medLoginPage = Substitute.For<MedLoginPage>();
        }

        [Test]
        public void NavigateToPatientLogInPage_Test()
        {
            //Arrange
            LogInPage uut = new LogInPage();


            //Act
            uut.NavigateToMedLogInPage();

            //Assert //TODO Ikke lavet
            Assert.Pass();
        }
    }
}
