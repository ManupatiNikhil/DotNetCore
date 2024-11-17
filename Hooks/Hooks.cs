using SpecFlowProject.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly WebDriverManager _driverManager;

        public Hooks(WebDriverManager driverManager)
        {
            _driverManager = driverManager;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverManager.GetWebDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverManager.CloseDriver();
        }
    }
}
