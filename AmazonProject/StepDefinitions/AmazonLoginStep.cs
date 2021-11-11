using AmazonProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AmazonProject.StepDefinitions
{
    [Binding]
    public class AmazonLoginStep
    {
        AmazonLoginPage amazonLoginPage;

        public AmazonLoginStep()
        {
            amazonLoginPage = new AmazonLoginPage();
        }
    }
}
