using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"User logged in and clicks on Skills Tab")]
        public void GivenUserLoggedInAndClicksOnSkillsTab()
        {
            ExcelLibHelper.PopulateInCollection(@"C:\Users\might\OneDrive\Desktop\Studying testing\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skill");
            Skills.SkillsSteps();
        }

        [When(@"user try to Edit Skill Details")]
        public void WhenUserTryToEditSkillDetails()
        {
            ExcelLibHelper.PopulateInCollection(@"C:\Users\might\OneDrive\Desktop\Studying testing\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skill");
            Skills.EditSkillSteps();
        }


        [Given(@"User have logged in and clicks on Skills tab")]
        public void GivenUserHaveLoggedInAndClicksOnSkillsTab()
        {
            Skills.DeleteSkillSteps();
        }
        
        
       
    }
}
