using POMHomework.Models._03AutomationPracticeRegistration;
using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._03AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage : BasePage
    {
        public AutomationPracticeRegistrationPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://automationpractice.com/index.php";

        public void NavigationEmailForm(AutomationPracticeRegistrationModel user)
        {
            SignInButton.Click();
            EmailAddressField.SetText(user.EmailAddressField);
            CreateAccountButton.Click();

            EmailField.ScrollTo().ToBeVisible();
        }
    }
}
