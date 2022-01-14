using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture1.Tests
{
    [TestClass]
    public class PersonTests
    {
            Person Person = new();
            string UserName = "Inigo.Montoya";
            string Password = "YouKilledMyF@ther!";

        [TestInitialize]
        public void Initialize()
        {
            //Password = "YouKilledMyFather!";
        }

        [TestMethod]
        public void SimpleTest_GivenValidUserNameandPassword_Success()
        {
            bool success = Person.Login(UserName, Password); 
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void InvalidLogin_GivenInvalidCredentials_Failure()
        {
            Password = "InvalidPwd";
            bool result = Person.Login(UserName, Password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Login_GivenInvalidUsername_Failure()
        { 
            UserName = "InvalidPwd"};
            bool result = Person.Login(UserName, Password);
            Assert.IsFalse(result);
    }
}