using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PNC_Bank
{
    public class Elements:DriverClass
    {
        public IWebElement CheckingLink => Driver.FindElement(Identifier.ExploreProductAndServiceLink("checking"));
        public IWebElement CreditcardLink => Driver.FindElement(Identifier.ExploreProductAndServiceLink("credit-cards"));
        public IWebElement SavingsLink => Driver.FindElement(Identifier.ExploreProductAndServiceLink("savings"));
        public IWebElement ProductAndService => Driver.FindElement(Identifier.ProductAndService);
        public List<IWebElement> TotalLinks => Driver.FindElements(Identifier.links).ToList();
        public IWebElement AutoLoanLink => Driver.FindElement(Identifier.AutoLoanLink);
        public List<IWebElement> ResultsTable => Driver.FindElements(Identifier.Results).ToList();
        public IWebElement Table => Driver.FindElement(Identifier.Results);
        
    }
}
