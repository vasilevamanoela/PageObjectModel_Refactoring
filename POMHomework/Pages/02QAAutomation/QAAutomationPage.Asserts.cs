using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._02QAAutomation
{
    public partial class QAAutomationPage 
    {
        public void AssertCorrectCourseTitle(WebElement element)
        {
            Assert.AreEqual("QA Automation - май 2020", element.Text);
        }

        public void AssertCorrectHeadingTag(WebElement element)
        {
            Assert.IsTrue("h1" == element.WrappedElement.TagName);
        }
    }
}
