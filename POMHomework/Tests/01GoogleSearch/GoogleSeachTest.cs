using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Factories._01GoogleSearch;
using POMHomework.Models._01GoogleSearch;
using POMHomework.Pages._01GoogleSearch;

namespace POMHomework.Tests._01GoogleSearch
{
    [TestFixture]
    public class GoogleSeachTest : BaseTest
    {
        private GoogleSearchPage _googleSearchPage;
        private GoogleSearchModel _input;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _googleSearchPage = new GoogleSearchPage(Driver);
            _googleSearchPage.NavigateTo();
            _input = GoogleSeachFactory.Create();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot();
            }

            Driver.Quit();
        }

        [Test]
        public void SeleniumTitleDisplayed_When_GoogleSearchFirstResult()
        {
            _googleSearchPage.FillGoogleSearch(_input);

            _googleSearchPage.AssertFirstResultTitle(_googleSearchPage.FirstResult);
        }
    }
}
