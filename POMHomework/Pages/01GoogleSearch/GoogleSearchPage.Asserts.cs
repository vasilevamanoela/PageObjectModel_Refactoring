using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Pages._01GoogleSearch
{
    public partial class GoogleSearchPage 
    {
        public void AssertFirstResultTitle(WebElement element)
        {
            Assert.AreEqual("Selenium", element.Text);
        }
    }
}
