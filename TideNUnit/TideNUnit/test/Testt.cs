using NUnit.Framework;
using TideNUnit.DMethod;
using TideNUnit.PageOMethod;
using TideNUnit.Utility;
namespace TideNUnit
{
    public class Tests
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ExtentR.generateReport();
        }
        [SetUp]
        public void Setup()
        {
            method.InitializeDriver();
        }
        [Test]
        public void LiveChattest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("LiveChatTest");
            LiveChat.NavigateURL();
            LiveChat.ClickOnLiveChat();
            LiveChat.ScrollToLiveChat();
            LiveChat.TakeSshottest();
        }
        [Test]
        public void ContactUstest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("ContactUstest");
            ContactUs.NavigateURL();
            ContactUs.ClickOnButton();
            ContactUs.TakeSshottest();
        }
         [Test]
        public void Selectloctiontest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("Selectloctiontest");
            Selectloction.NavigateURL();
            Selectloction.ClickOnbutton();
            Selectloction.SelectLanguage();
            Selectloction.TakeSshottest();
        }
        [Test]
        public void SearchBartest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("SearchBartest");
            SearchBar.NavigateURL();
            SearchBar.ClickOnSearchBar();
            SearchBar.EnterDataInSearchBar();
            SearchBar.TakeSshottest();
        }
        [Test]
        public void ShopProductstest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("ShopProductstest");
            ShopProducts.NavigateURL();
            ShopProducts.ClickOnButton();
            ShopProducts.SelectProducts();
            ShopProducts.ClickOnFindRetailers();
            ShopProducts.TakeSshottest();
        }
        [Test]
        public void OurCommitmenttest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("OurCommitmenttest");
            OurCommitment.NavigateURL();
            OurCommitment.ClickOnButton();
            OurCommitment.ScrollToElement();
            OurCommitment.TakeSshottest();
        }

        [Test]
        public void HowtoWashClothestest()
        {
              ExtentR.test = ExtentR.extent.CreateTest("HowtoWashClothestest");
            HowtoWashClothes.NavigateURL();
            HowtoWashClothes.ClickOnButton();
            HowtoWashClothes.TakeSshottest();
        }          
        [Test]
        public void What_sNewtest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("What_sNewtest");
            What_sNew.NavigateURL();
            What_sNew.ClickOnWhat_sNewButton();         
            What_sNew.TakeSshottest();
        }     
        [Test]
        public void Registertest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("Registertest");
            Register.NavigateURL();
            Register.ClickOnButton();
            Register.ClickontheSignup();
            Register.TakeSshottest();
        }
        [Test]
        public void Logintest()
        {
            ExtentR.test = ExtentR.extent.CreateTest("Logintest");
            Login.NavigateURL();
            Login.EnterEmail();
            Login.EnterPassword();
            Login.Loginn();
            Login.TakeSshottest();
        }

        [TearDown]
        public void TearDown()
        {
            method.CloseDriver();
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ExtentR.flushReport();
        }
    }
}