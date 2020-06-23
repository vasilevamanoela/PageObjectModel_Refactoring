using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._02QAAutomation
{
    public partial class QAAutomationPage : BasePage
    {
        public QAAutomationPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.softuni.bg";

        public void NavigationForm()
        {
            LearningsButton.Click();
            ActiveModulsButton.Click();
            QAModulLink.Click();

            CourseLink.ScrollTo().ToBeVisible().Click();
        }
    }
}
