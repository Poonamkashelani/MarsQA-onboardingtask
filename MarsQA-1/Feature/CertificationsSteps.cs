using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class CertificationsSteps
    {
        [Given(@"The User Clicks on Certificate Tab")]
        public void GivenTheUserClicksOnCertificateTab()
        {
            ExcelLibHelper.PopulateInCollection(@"C:\Users\might\OneDrive\Desktop\Studying testing\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Certifications");
            Certifications.CeritificationsSteps();
        }

        [Given(@"The User is on Certificate Tab")]
        public void GivenTheUserIsOnCertificateTab()
        {
            ExcelLibHelper.PopulateInCollection(@"C:\Users\might\OneDrive\Desktop\Studying testing\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Certifications");
            Certifications.EditCertification();
        }

        [Given(@"The User is on Certification Tab")]
        public void GivenTheUserIsOnCertificationTab()
        {
            Certifications.DeleteCertification();
        }
    }
}