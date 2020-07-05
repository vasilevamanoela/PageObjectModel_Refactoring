using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Factories._03AutomationPracticeRegistration;
using POMHomework.Models._03AutomationPracticeRegistration;
using POMHomework.Pages._03AutomationPracticeRegistration;
using POMHomework.Tests._01GoogleSearch;

namespace POMHomework.Tests._03AutomationPracticeRegistration
{
    [TestFixture]
    public class AutomationPracticeRegistrationTest : BaseTest
    {
        private AutomationPracticeRegistrationPage _practiceRegistrationPage;
        private AutomationPracticeRegistrationModel _user;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _practiceRegistrationPage = new AutomationPracticeRegistrationPage(Driver);
            _practiceRegistrationPage.NavigateTo();
            _user = AutomationPracticeRegistrationFactory.Create();
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
        public void SameEmailSetToEmailField_When_EntersValidEmailInCreateAnAccountSection()
        {
            _practiceRegistrationPage.NavigationEmailForm(_user);

            _practiceRegistrationPage.AssertThatTheEmailsAreSame(_practiceRegistrationPage.EmailField);
        }
    }
}
