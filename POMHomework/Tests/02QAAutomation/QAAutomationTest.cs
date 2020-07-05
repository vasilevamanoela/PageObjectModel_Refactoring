using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Pages._02QAAutomation;
using POMHomework.Tests._01GoogleSearch;

namespace POMHomework.Tests._02QAAutomation
{
    [TestFixture]
    public class QAAutomationTest : BaseTest
    {
        private QAAutomationPage _courseAutomationPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _courseAutomationPage = new QAAutomationPage(Driver);
            _courseAutomationPage.NavigateTo();
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
        public void QAAutomationTitleDisplayed_When_NavigateToQAAutomationCoursePage()
        {
            _courseAutomationPage.NavigationForm();

            _courseAutomationPage.AssertCorrectCourseTitle(_courseAutomationPage.CourseTitle);
        }

        [Test]
        public void H1HeadingTagExist_When_NavigateToQAAutomationCoursePage()
        {
            _courseAutomationPage.NavigationForm();

            _courseAutomationPage.AssertCorrectHeadingTag(_courseAutomationPage.CourseTitle);
        }
    }
}
