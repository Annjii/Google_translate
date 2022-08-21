using Msa3part.Utility;
using System;
using NUnit;
using Msa3part;
using Msa3part.baseMethod;



namespace Msa3part.Test
{
    public class UnitTest1
    {
        [OneTimeSetUp]
        public void oneTimeSetUp()
        {
            ExtentR.generateReport();
            log4nets.log.Info("Generate extent report");
        }
        [SetUp]
        public void SetUp()
        {
            WebsiteMethod.InitializeDriver();
            log4nets.log.Info("Driver Intialize");
        }
        [Test]
        public void test1()
        {
            ExtentR.test = ExtentR.Extent.CreateTest("Passing Test");
            WebsiteMethod.NavigateURL();
            log4nets.log.Info("Navigate to url");
        }
        [TearDown]
        public void TearDown()
        {
            WebsiteMethod.TearDown();
            log4nets.log.Info("Close the driver");
            ExtentR.flushReport();
        }
    }
}