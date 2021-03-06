﻿using OpenQA.Selenium;
using SandBoxAppSelleniumTests.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxAppSelleniumTests.Pages
{
    public class PeoplePage : PageObject<PeoplePage>
    {
        #region XPathValues
        public string createPersonXPath = "//a[contains(@class,'btn mb-4 btn-primary float-right')]";
        public string personXPath = "//a[@class='list-group-item list-group-item-action']";
        #endregion

        #region WebElements
        public IWebElement CreatePersonButton { get { return FindElement(By.XPath(createPersonXPath), 15); } }
        public IReadOnlyCollection<IWebElement> People { get { return FindElements(By.XPath(personXPath), 15); } }
    
#endregion

#region Methods
        public void GoToPeoplePage()
        {
            WrappedDriver.Navigate().GoToUrl(Constants.PEOPLE);
        }

       

        public void CreateNewPerson()
        {
            CreatePersonButton.Click();
        }
        #endregion
    }
}
