using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._04AutomationPracticeRegistrationNegative
{
    public partial class PracticeRegistrationPage 
    {
        public WebElement SignInButton => Driver.FindElement(By.XPath("//a[@class='login']"));

        public WebElement EmailAddressField => Driver.FindElement(By.Id("email_create"));

        public WebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));

        public WebElement RadioButton => Driver.FindElement(By.XPath("//div[@id='uniform-id_gender1']"));

        public WebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public WebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public WebElement Password => Driver.FindElement(By.Id("passwd"));

        public WebElement Date => Driver.FindElement(By.Id("days"));

        public WebElement Month => Driver.FindElement(By.Id("months"));

        public WebElement Year => Driver.FindElement(By.Id("years"));

        public WebElement Address => Driver.FindElement(By.Id("address1"));

        public WebElement City => Driver.FindElement(By.Id("city"));

        public WebElement State => Driver.FindElement(By.Id("id_state"));

        public WebElement ZipCode => Driver.FindElement(By.Id("postcode"));

        public WebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));

        public WebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

        public WebElement ErrorMessage => Driver.FindElement(By.XPath("//div[@class='alert alert-danger']//li"));
    }
}
