using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace POCTestProject.Tests.StepFiles
{
    [Binding]
    public class GmailAccountLoginSteps : POCTestProject.Tests.Hooks.MyHooks
    {
        [Given(@"I navigate to the Gmail login page")]
        public void GivenINavigateToTheGmailLoginPage()
        {
            driver.Navigate().GoToUrl("https://bstackdemo.com/");
            Assert.AreEqual("StackDemo", driver.Title);
            string productOnPageText = driver.FindElement(By.XPath("//*[@id=\"1\"]/p")).Text;

            driver.FindElement(By.XPath("//*[@id=\"1\"]/div[4]")).Click();
            bool cartOpened = driver.FindElement(By.XPath("//*[@class=\"float-cart__content\"]")).Displayed;
            Assert.AreEqual(cartOpened, true);
            string productOnCartText = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div/div[2]/div[2]/div[2]/div/div[3]/p[1]")).Text;
            Assert.AreEqual(productOnCartText, productOnPageText);
        }

        //[When(@"I enter my '([^']*)' and '([^']*)'")]
        //public void WhenIEnterMyAnd(string username, string password)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I click the Sign In button")]
        //public void WhenIClickTheSignInButton()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"I should be logged in to my Gmail account")]
        //public void ThenIShouldBeLoggedInToMyGmailAccount()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I enter an invalid '([^']*)' or '([^']*)'")]
        //public void WhenIEnterAnInvalidOr(string username, string password)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"I should see an error message")]
        //public void ThenIShouldSeeAnErrorMessage()
        //{
        //    throw new PendingStepException();
        //}

    }
}
