using System;
using System.Collections.Generic;
using System.Text;
using MoleTrackerWebsite.Pages;
using NUnit.Framework;


namespace MoleTrackerWebsite_PW.UnitTests
{
    public class UT_LogInPage
    {
        private LogInPage _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new LogInPage();

        }

        [Test]
        public void CallNavigateToPatientLoginPageMethod()
        {

        }
    }
}
