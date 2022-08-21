namespace Selerium_test
{
    internal interface IWebDriver
    {
        object Navigate();
        IWebElement FindElement(object p);
        void Close();
    }
}