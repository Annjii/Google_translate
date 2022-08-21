using Tide_com_Nuint.DMethod;
using Tide_com_Nuint.PageOMethod;
using Tide_com_Nuint.Utility;
namespace Tide_com_Nuint
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
            LiveChat.NavigateURL();
            LiveChat.ClickOnLiveChat();
            LiveChat.ScrollToLiveChat();
            LiveChat.TakeSshottest();
        }
        [Test]
        public void ContactUstest()
        {
            ContactUs.NavigateURL();
            ContactUs.ClickOnButton();
            ContactUs.TakeSshottest();
        }
         [Test]
        public void Selectloctiontest()
        {
            Selectloction.NavigateURL();
            Selectloction.ClickOnbutton();
            Selectloction.SelectLanguage();
            Selectloction.TakeSshottest();
        }
        [Test]
        public void SearchBartest()
        {
            SearchBar.NavigateURL();
            SearchBar.ClickOnSearchBar();
            SearchBar.EnterDataInSearchBar();
            SearchBar.TakeSshottest();
        }
        [Test]
        public void ShopProductstest()
        {
            ShopProducts.NavigateURL();
            ShopProducts.ClickOnButton();
            ShopProducts.SelectProducts();
            ShopProducts.ClickOnFindRetailers();
            ShopProducts.TakeSshottest();
        }
        [Test]
        public void OurCommitmenttest()
        {
            OurCommitment.NavigateURL();
            OurCommitment.ClickOnButton();
            OurCommitment.ScrollToElement();
            OurCommitment.TakeSshottest();
        }

        [Test]
        public void HowtoWashClothestest()
        {
            HowtoWashClothes.NavigateURL();
            HowtoWashClothes.ClickOnButton();
            HowtoWashClothes.TakeSshottest();
        }          
        [Test]
        public void What_sNewtest()
        {
            What_sNew.NavigateURL();
            What_sNew.ClickOnWhat_sNewButton();         
            What_sNew.TakeSshottest();
        }     
        [Test]
        public void Registertest()
        {
            Register.NavigateURL();
            Register.ClickOnButton();
            Register.ClickontheSignup();
            Register.TakeSshottest();
        }
        [Test]
        public void Logintest()
        {
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