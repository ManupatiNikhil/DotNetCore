using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.Drivers
{
    public class WebDriverManager
    {
        private IWebDriver? _webDriver;

        public IWebDriver GetWebDriver()
        {
            if (_webDriver == null)
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                _webDriver = new ChromeDriver(options);
            }

            return _webDriver;
        }

        public void CloseDriver()
        {
            _webDriver?.Quit();
            _webDriver = null;
        }
    }
}
