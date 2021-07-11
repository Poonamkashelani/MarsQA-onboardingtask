using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    internal class Login
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}