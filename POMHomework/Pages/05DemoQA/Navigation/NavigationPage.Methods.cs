using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Navigation
{
    public partial class NavigationPage : BasePage
    {
        public NavigationPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/";

        public void Navigation(string sectionName)
        {
            InteractionButton.Click();

            InteractionSideBarMenu(sectionName).ScrollTo().ToBeVisible().Click();           
        }
    }
}
