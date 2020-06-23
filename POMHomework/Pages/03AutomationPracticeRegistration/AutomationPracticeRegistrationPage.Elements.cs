using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._03AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage
    {
        public WebElement SignInButton => Driver.FindElement(By.XPath("//a[@class='login']"));

        public WebElement EmailAddressField => Driver.FindElement(By.Id("email_create"));

        public WebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));

        public WebElement EmailField => Driver.FindElement(By.Id("email"));
    }
}
