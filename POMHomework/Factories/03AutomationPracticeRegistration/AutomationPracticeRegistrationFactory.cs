using AutoFixture;
using POMHomework.Models._03AutomationPracticeRegistration;

namespace POMHomework.Factories._03AutomationPracticeRegistration
{
    public static class AutomationPracticeRegistrationFactory
    {
        public static AutomationPracticeRegistrationModel Create()
        {
            var fixture = new Fixture();

            return new AutomationPracticeRegistrationModel
            {
                EmailAddressField = fixture.Create<string>() + "@gmail.com",
            };
        }
    }
}
