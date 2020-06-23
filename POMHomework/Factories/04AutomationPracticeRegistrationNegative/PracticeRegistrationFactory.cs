using AutoFixture;
using POMHomework.Models._04AutomationPracticeRegistrationNegative;

namespace POMHomework.Factories._04AutomationPracticeRegistrationNegative
{
    public static class PracticeRegistrationFactory
    {
        public static PracticeRegistrationModel Create()
        {
            var fixture = new Fixture();

            return new PracticeRegistrationModel
            {
                EmailAddressField = fixture.Create<string>() + "@gmail.com",
                FirstName = "Pesho",
                LastName = "Peshov",
                Password = "123456",
                Address = "Str. 6",
                City = "Alaska",
                ZipCode = "00000",
                MobilePhone = "8923457542",
            };
        }
    }
}
