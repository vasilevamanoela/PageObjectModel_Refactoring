using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Navigation
{
    public partial class NavigationPage 
    {
        public WebElement InteractionButton => Driver.FindElement(By.XPath("//*[normalize-space(text())='Interactions']/ancestor::div[contains(@class, 'top-card')]"));

        public WebElement InteractionSideBarMenu(string sectionName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']"));

        public WebElement PageHeader => Driver.FindElement(By.ClassName("main-header"));
    }
}
