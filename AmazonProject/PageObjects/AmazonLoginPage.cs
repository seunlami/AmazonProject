using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonProject.PageObjects
{
    class AmazonLoginPage
    {
        public AmazonLoginPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;
    }
}
