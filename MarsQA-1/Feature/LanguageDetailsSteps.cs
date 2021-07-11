using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LanguageDetailsSteps
    {
        [Given(@"Add Language")]
        public void GivenAddLanguage()
        {
            ExcelLibHelper.PopulateInCollection(@"C:\Users\might\OneDrive\Desktop\Studying testing\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
            LanguageClass.LanguagesSteps();
        }

        [Given(@"Update Language Details")]
        public void GivenUpdateLanguageDetails()
        {
            ExcelLibHelper.PopulateInCollection(@"C:\Users\might\OneDrive\Desktop\Studying testing\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
            LanguageClass.EditLanguage();
        }

        [Given(@"Delete Language")]
        public void GivenDeleteLanguage()
        {
            LanguageClass.DeleteLang();
        }
    }
}