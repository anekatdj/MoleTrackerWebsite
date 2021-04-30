using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataClasses.Domain;
using MoleTrackerWebsite.Pages;
using NSubstitute;
using NUnit.Framework;

namespace MedWebNUnitTest.PresentationLayerTest
{
    public class TestMedLoginPage
    {
        private MedLoginPage uut;
        private ILogInController logInController;
        private LoginInfoDomain loginData;
        [SetUp]
        public void Setup()
        {
            logInController = Substitute.For<ILogInController>();
            uut = new MedLoginPage();
            //uut.LogInController = Substitute.For<ILogInController>();
        }
        [Test]
        public void Login_Test_CallsLogin_on_LogInController()
        {
            //Arrange

            //Act
            uut.Login();

            //Arrange
            logInController.Received(1).Login(Arg.Any<LoginInfoDomain>());
        }
        [Test]
        public void Login_Test_TrueLogin()
        {
            //Arrange
            logInController.Login(Arg.Any<LoginInfoDomain>()).Returns(true);

            //Act

            var returnValue = uut.LoginFailed;

            //Arrange
            Assert.AreEqual(returnValue,false);
        }
        [Test]
        public void Login_Test_FalseLogin()
        {
            //Arrange
            uut = new MedLoginPage();
            logInController.Login(Arg.Any<LoginInfoDomain>()).Returns(false);

            //Act

            var returnValue = uut.LoginFailed;

            //Arrange
            Assert.AreEqual(returnValue, true);
        }
    }
}
