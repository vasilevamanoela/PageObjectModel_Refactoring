using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._01GoogleSearch
{
    public partial class GoogleSearchPage
    {
        public WebElement InputField => Driver.FindElement(By.Name("q"));

        public WebElement FirstResult => Driver.FindElement(By.XPath("//h3[text()='Selenium.dev']"));
    }
}
