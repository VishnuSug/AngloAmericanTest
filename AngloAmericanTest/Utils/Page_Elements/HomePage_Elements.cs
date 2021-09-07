using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AngloAmericanTest.Utils.Page_Elements.HomePage_Elements
{
    public  class HomePage_Elements
    {
        public IWebDriver driver;

        public HomePage_Elements(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        // Anglo American logo on the header
        [FindsBy(How = How.Id, Using ="logo")]
        public IWebElement AngloAmericanLogo;
        
        [FindsBy(How = How.XPath, Using = "/html/body/form/header/div/div/div[3]/div[1]/nav/ul/li[1]/a/span")]
        public IWebElement AboutUs;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[6]/div/div/section[3]/div/div[2]/div/div/div[1]/article[7]/div/a")]
        public IWebElement LeadershipTeam;

        [FindsBy(How = How.XPath, Using = "/html/body/form/section[2]/div/div/div[2]/div/ul/li[2]/a")]
        public IWebElement GroupManagementCommittee;
    }
}
