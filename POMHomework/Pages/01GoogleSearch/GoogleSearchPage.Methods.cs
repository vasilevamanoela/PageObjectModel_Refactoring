using OpenQA.Selenium;
using POMHomework.Models._01GoogleSearch;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._01GoogleSearch
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(WebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "http://www.google.com";

        public void FillGoogleSearch(GoogleSearchModel input)
        {
            InputField.SetText(input.InputField + Keys.Enter);
        }
    }
}
