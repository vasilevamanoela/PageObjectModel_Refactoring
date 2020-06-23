using POMHomework.Models._01GoogleSearch;

namespace POMHomework.Factories._01GoogleSearch
{
    public static class GoogleSeachFactory
    {
        public static GoogleSearchModel Create()
        {
            return new GoogleSearchModel
            {
                InputField = "selenium",
            };
        }
    }
}
