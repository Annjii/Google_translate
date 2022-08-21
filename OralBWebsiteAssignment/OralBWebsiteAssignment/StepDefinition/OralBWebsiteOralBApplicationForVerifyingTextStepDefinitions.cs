using OralBWebsiteAssignment.Pageofobjectmodel;
using System;
using TechTalk.SpecFlow;
using OralBWebsiteAssignment.Utilities;

namespace OralBWebsiteAssignment.StepDefinition
{
    [Binding]
    public class OralBWebsiteOralBApplicationForVerifyingTextStepDefinitions
    {
        websitesMethod obj = new websitesMethod();
        [Given(@"Load the OralB Website")]
        public void GivenLoadTheOralBWebsite()
        {
            obj.loadWebsite("https://www.oral-b.co.in/en-in");
        }

        [When(@"You click on Kid's brushes from Dropdown")]
        public void WhenYouClickOnKidsBrushesFromDropdown()
        {
            obj.ClickOnElement("(//a[@class='event_menu_click'])[2]");
        }

        [Then(@"Verify the text Kids is displayed")]
        public void ThenVerifyTheTextKidsIsDisplayed()
        {
            obj.VerifyText("/html/body/div/div[3]/div/div[3]/section[1]/div/div/div/div/div/div/h1/span");
            obj.ScreenShot("kid'sBrushWindow");
        }

        [Given(@"Load the  Website")]
        public void GivenLoadTheWebsite()
        {
            obj.loadWebsite("https://www.oral-b.co.in/en-in");
        }

        [When(@"Click on Search Icon on top Corner")]
        public void WhenClickOnSearchIconOnTopCorner()
        {
            obj.ClickOnElement("//a[@aria-label='SEARCH-callToActionLink']");
        }

        [When(@"Search ""([^""]*)"" in searchbox")]
        public void WhenSearchInSearchbox(string battery)
        {
            obj.SearchInSearchBox(battery);
        }


        [When(@"Select First link")]
        public void WhenSelectFirstLink()
        {
            obj.ClickOnElement("(//a[@href='https://www.oral-b.co.in/en-in/products/battery-powered-toothbrushes'])[1]");
        }

        [Then(@"Verify the text BATTERY is displayed")]
        public void ThenVerifyTheTextBATTERYIsDisplayed()
        {
            obj.VerifyText("//*[@class='ob-heading ob-display-2-xl']");
            obj.ScreenShot("BatteryToothbrushWindow");
            execlfile.ExcelFile();
        }

        [Given(@"Load the Webpage")]
        public void GivenLoadTheWebpage()
        {
            obj.loadWebsite("https://www.oral-b.co.in/en-in");
        }

        [When(@"Click on Floss Under Shop in footer")]
        public void WhenClickOnFlossUnderShopInFooter()
        {
            obj.ScrollDownToElement("(//a[@aria-label='Floss-callToActionLink'])");
            obj.ClickOnElement("(//a[@aria-label='Floss-callToActionLink'])");
        }

        [Then(@"Verify FLOSS PICKS appearing in the list products")]
        public void ThenVerifyFLOSSPICKSAppearingInTheListProducts()
        {
            obj.VerifyText("//*[@class='ob-heading ob-display-2-xl']");
            obj.ScreenShot("FlossWindow");
        }
    }
}
