using NUnit.Framework;
using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._03AutomationPracticeRegistration
{
    public partial class AutomationPracticeRegistrationPage 
    {
        public void AssertThatTheEmailsAreSame(WebElement element)
        {
            Assert.AreEqual(element.Text, element.GetProperty());
        }
    }
}
