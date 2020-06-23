using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Utilities.Extensions
{
    public static class DriverExtensions
    {
        public static string GetCssColor(this WebElement element)
        {
            return element.WrappedElement.GetCssValue("background-color");
        }

        public static string GetProperty(this WebElement element)
        {
            return element.WrappedElement.GetProperty("value");
        }

    }
}
