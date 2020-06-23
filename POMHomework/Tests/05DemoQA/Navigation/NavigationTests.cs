using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using POMHomework.Pages._05DemoQA.Navigation;
using POMHomework.Tests._01GoogleSearch;
using System.IO;

namespace POMHomework.Tests._05DemoQA.Navigation
{
    [TestFixture]
    public class NavigationTests : BaseTest
    {
        private NavigationPage _navigationPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _navigationPage = new NavigationPage(Driver);
            _navigationPage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void InteractionSectionNameDisplayed_When_NavigationToInteractions(string sectionName)
        {
            _navigationPage.Navigation(sectionName);

            _navigationPage.AssertCorrectTitleSection(sectionName, _navigationPage.PageHeader);
        }
    }
}
