using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._04AutomationPracticeRegistrationNegative
{
    public partial class PracticeRegistrationPage
    {
        public void AssertErrorMessage(string message, WebElement element)
        {
            Assert.AreEqual(message, element.Text);
        }
    }
}
