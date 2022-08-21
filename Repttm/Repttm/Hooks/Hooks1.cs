﻿using Repttm.Drivers;
using Repttm.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Repttm.Hooks
{
    [Binding]
    public  class Hooks1
    {

        [BeforeScenario]
        public static void BeforeScenario()
        {
            DriverMethod.InitializeDriver();
            ExtendReport.scenarioReport();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            DriverMethod.closeDriver();         
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtendReport.generateReport();
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtendReport.flushReport();
        }
        [BeforeFeature]
        public static void BeforeFeature()
        {
            ExtendReport.featureReport();
        }
        [AfterStep]
        public static void AfterStep()
        {
            ExtendReport.scenarioStepReport();
        }
    }
}
