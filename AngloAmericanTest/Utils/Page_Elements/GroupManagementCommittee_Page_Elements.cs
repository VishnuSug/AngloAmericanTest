using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AngloAmericanTest.Utils.Page_Elements.GroupManagementCommittee_Page_Elements
{
    class GroupManagementCommittee_Page_Elements
    {
        public IWebDriver driver;

        public GroupManagementCommittee_Page_Elements(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How =How.XPath, Using = "/html/body/form/section[2]/div/div/div[1]/article/div[2]")]
        public IWebDriver GroupManagementPageIdentifier;
    }
}
