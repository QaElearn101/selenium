using OpenQA.Selenium;


namespace PNC_Bank
{
    public static class Identifier
    {
        public static By ExploreProductAndServiceLink(string linkText) => By.XPath(".//div[@id ='mostViewedTout-container']//a[contains(@href,'"+ linkText + "')]");
        public static By links => By.XPath(".//div[@id ='mostViewedTout-container']//a");
        public static By ProductAndService => By.XPath(".//ul[@class = 'level-2  expanded']//span[text() = 'Products & Services']");
        public static By AutoLoanLink => By.XPath("..li//a[contains(@href,'auto-loan')]");
        public static By Results => By.XPath(".//div[@id = 'auto']");
    }
}
