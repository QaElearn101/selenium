using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;


namespace PNC_Bank
{
    [TestClass]
    public class UnitTest1:DriverClass
    {

        public Elements elemnts;
        [TestMethod]
        public void TestMethod1()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(elemnts.ProductAndService).Perform();
            Task.Delay(500).Wait();
            elemnts.AutoLoanLink.Click();
            

        }
        [TestMethod]
        public void ClickLinks()
        {
           // Assert.IsTrue(elemnts.ResultsTable.Count > 0, "No result found");


            

            Assert.IsTrue(elemnts.Table.Displayed, "no result found");
            

        }

        [TestInitialize]
        public void Initialize()
        {
            elemnts = new Elements();
            DriverInitialize(GlobalVariables.PncBankUrl);
        }
      
        [TestCleanup]
        public void TestCleanUp()
        {
            Driver.Quit();
        }





    }
}
