using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Selenium_AutoTest_Final_Project
{
    [TestClass]
    public class TestExecution
    {
        Ecommerce EcommerceApp = new Ecommerce();

        [TestMethod]
        public void TestCase_001()
        {
            EcommerceApp.Web_Login("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }
        [TestMethod]
        public void TestCase_002()
        {
            EcommerceApp.Category("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }
        [TestMethod]
        public void TestCase_003()
        {
            EcommerceApp.Purchase("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }
    }
}
