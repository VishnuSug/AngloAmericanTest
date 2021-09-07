using System;
using TechTalk.SpecFlow;
using AngloAmericanTest.Utils;
using AngloAmericanTest.Utils.Shared_Functions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngloAmericanTest.Utils.Page_Elements;
using AngloAmericanTest.Utils.Page_Elements.HomePage_Elements;
using AngloAmericanTest.Utils.Page_Elements.GroupManagementCommittee_Page_Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AngloAmericanTest.StepDefinitions
{
    [Binding]
    public class GroupManagementCommitteePageSteps : TestSetUp_Chrome
    {

        [Given(@"I have navigated to Anglo American website")]
        public void GivenIHaveNavigatedToAngloAmericanWebsite()
        {
            driver.Navigate().GoToUrl("https://www.angloamerican.com/");
            Thread.Sleep(3000);
            Assert.IsTrue(driver.Title.ToLower().Contains("angloamerican"));
        }
        
        [Given(@"I have click on the about us link")]
        public void GivenIHaveClickOnTheAboutUsLink()
        {
            HomePage_Elements HomePage_Elements = new HomePage_Elements(driver);

            HomePage_Elements.AboutUs.Click();
        }
        
        [Given(@"I have click on the leadership link")]
        public void GivenIHaveClickOnTheLeadershipLink()
        {
            HomePage_Elements HomePage_Elements = new HomePage_Elements(driver);

            HomePage_Elements.LeadershipTeam.Click();
        }
        
        [When(@"I press the group management committee button")]
        public void WhenIPressTheGroupManagementCommitteeButton()
        {
            HomePage_Elements HomePage_Elements = new HomePage_Elements(driver);

            HomePage_Elements.GroupManagementCommittee.Click();
        }
        
        [Then(@"I should be navigate to Group Management Committee page")]
        public void ThenIShouldBeNavigateToGroupManagementCommitteePage()
        {
            GroupManagementCommittee_Page_Elements GroupManagementCommittee_Page_Elements = new GroupManagementCommittee_Page_Elements(driver);

        
        }
    }
}
