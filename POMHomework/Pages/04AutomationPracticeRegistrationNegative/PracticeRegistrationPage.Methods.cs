using OpenQA.Selenium.Support.UI;
using POMHomework.Models._04AutomationPracticeRegistrationNegative;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._04AutomationPracticeRegistrationNegative
{
    public partial class PracticeRegistrationPage : BasePage
    {
        public PracticeRegistrationPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://automationpractice.com/index.php";

        public void FillEmailForm(PracticeRegistrationModel user)
        {
            SignInButton.Click();
            EmailAddressField.SetText(user.EmailAddressField);
            CreateAccountButton.Click();
            RadioButton.Click();
            FirstName.SetText(user.FirstName);
            LastName.SetText(user.LastName);
            Password.SetText(user.Password);

            SelectElement date = new SelectElement(Date.WrappedElement);
            date.SelectByValue("1");
            SelectElement month = new SelectElement(Month.WrappedElement);
            month.SelectByValue("2");
            SelectElement year = new SelectElement(Year.WrappedElement);
            year.SelectByValue("2010");

            Address.SetText(user.Address);
            City.SetText(user.City);

            SelectElement state = new SelectElement(State.WrappedElement);
            state.SelectByValue("2");

            ZipCode.SetText(user.ZipCode);
            MobilePhone.SetText(user.MobilePhone);
            RegisterButton.Click();
        }
    }
}
