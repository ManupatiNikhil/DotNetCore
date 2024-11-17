using TechTalk.SpecFlow;

namespace DotnetSelenium.StepDefinitions
{
    [Binding]
    public class LoginFeatureSteps
    {
        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // Code to navigate to the login page
            Console.WriteLine("Navigating to the login page...");
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            // Code to input valid credentials
            Console.WriteLine("Entering valid credentials...");
        }

        [Then("I should be redirected to the dashboard")]
        public void ThenIShouldBeRedirectedToTheDashboard()
        {
            // Code to validate that the user is redirected to the dashboard
            Console.WriteLine("Validating redirection to the dashboard...");
        }
    }
}
