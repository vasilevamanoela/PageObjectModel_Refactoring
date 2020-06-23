using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._05DemoQA.Navigation
{
    public partial class NavigationPage 
    {
        public void AssertCorrectTitleSection(string sectionName, WebElement element)
        {
            Assert.AreEqual(sectionName, element.Text);
        }
    }
}
