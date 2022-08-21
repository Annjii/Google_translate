using System;
using NUnit;
using Nunittest;
using Nunittest.basemethod;
using Nunittest.Utility;



namespace Nunittest.test
{
    public class Nunittest
    {
         
        [OneTimeSetUp]
        public void oneTimeSetUp()
        {
            Extent.generateReport();
            lognet.log.Info("Generate extent report");
        }
        [SetUp]
        public void SetUp()
        {
            Method.InitializeDriver();
            lognet.log.Info("Driver Intialize");
        }
        [Test]
        public void test1()
        {
            Extent.test = Extent.extent.CreateTest("Passing Test");
            Method.NavigateURL();
            lognet.log.Info("Navigate to url");
        }
        [TearDown]
        public void TearDown()
        {
            Method.TearDown();
            lognet.log.Info("Close the driver");
            Extent.flushReport();
        }
    }
}