using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using POMHomework.Factories._04AutomationPracticeRegistrationNegative;
using POMHomework.Models._04AutomationPracticeRegistrationNegative;
using POMHomework.Pages._04AutomationPracticeRegistrationNegative;
using POMHomework.Tests._01GoogleSearch;
using System.IO;

namespace POMHomework.Tests._04AutomationPracticeRegistrationNegative
{
    [TestFixture]
    public class PracticeRegistrationNegativeTests : BaseTest 
    {
        private PracticeRegistrationPage _practiceFormPage;
        private PracticeRegistrationModel _user;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _practiceFormPage = new PracticeRegistrationPage(Driver);
            _practiceFormPage.NavigateTo();
            _user = PracticeRegistrationFactory.Create();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutFirstName()
        {
            //Arrange
            _user.FirstName = string.Empty;

            //Act
            _practiceFormPage.FillEmailForm(_user);

            //Assert
            string errorMessage = "firstname is required.";
            _practiceFormPage.AssertErrorMessage(errorMessage, _practiceFormPage.ErrorMessage);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutLastName()
        {
            //Arrange
            _user.LastName = string.Empty;

            //Act
            _practiceFormPage.FillEmailForm(_user);

            //Assert
            string errorMessage = "lastname is required.";
            _practiceFormPage.AssertErrorMessage(errorMessage, _practiceFormPage.ErrorMessage);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutPassword()
        {
            //Arrange
            _user.Password = string.Empty;

            //Act
            _practiceFormPage.FillEmailForm(_user);

            //Assert
            string errorMessage = "passwd is required.";
            _practiceFormPage.AssertErrorMessage(errorMessage, _practiceFormPage.ErrorMessage);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutAddress()
        {
            //Arrange
            _user.Address = string.Empty;

            //Act
            _practiceFormPage.FillEmailForm(_user);

            //Assert
            string errorMessage = "address1 is required.";
            _practiceFormPage.AssertErrorMessage(errorMessage, _practiceFormPage.ErrorMessage);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutCity()
        {
            //Arrange
            _user.City = string.Empty;

            //Act
            _practiceFormPage.FillEmailForm(_user);

            //Assert
            string errorMessage = "city is required.";
            _practiceFormPage.AssertErrorMessage(errorMessage, _practiceFormPage.ErrorMessage);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutZipCode()
        {
            //Arrange
            _user.ZipCode = string.Empty;

            //Act
            _practiceFormPage.FillEmailForm(_user);

            //Assert
            string errorMessage = "The Zip/Postal code you've entered is invalid. It must follow this format: 00000";
            _practiceFormPage.AssertErrorMessage(errorMessage, _practiceFormPage.ErrorMessage);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutPhoneNumber()
        {
            //Arrange
            _user.MobilePhone = string.Empty;

            //Act
            _practiceFormPage.FillEmailForm(_user);

            //Assert
            string errorMessage = "You must register at least one phone number.";
            _practiceFormPage.AssertErrorMessage(errorMessage, _practiceFormPage.ErrorMessage);
        }
    }
}
