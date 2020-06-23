using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._02QAAutomation
{
    public partial class QAAutomationPage 
    {
        public WebElement LearningsButton => Driver.FindElement(By.XPath("//span[text()='Обучения']"));

        public WebElement ActiveModulsButton => Driver.FindElement(By.XPath("//div[@class='category-nav']//div[contains(text(), 'Активни модули')]"));

        public WebElement QAModulLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Quality Assurance - октомври 2019')]"));

        public WebElement CourseLink => Driver.FindElement(By.XPath("//h4[contains(text(), 'QA Automation')]"));

        public WebElement CourseTitle => Driver.FindElement(By.XPath("//h1[@class='text-center']"));
    }
}
