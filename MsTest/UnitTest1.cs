using UserRegistrationMstest;
namespace MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UserFirstNameTest()
        {
            Pattern pattern = new Pattern();
           
             
                string result = pattern.ValidateFirstName("Vijay");
                string expected = "true";
                Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void UserLastNameTest()
        {
            Pattern patt = new Pattern();
            string expected = "true";
            string res = patt.ValidateLastName("Kumar");
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void UserEmailTest()
        {
            Pattern pattern = new Pattern();
            string expected = "true";
            string result = pattern.ValidateEmail("Vijay@gmail.com");
            Assert.AreEqual(expected , result);
        }
        [TestMethod]
        public void UserMobileNumbertest()
        {
            Pattern pattern = new Pattern();
            string expected = "true";
            string res = pattern.ValidatePhoneNumber("91 8847283564");
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void UserPasswordTest()
        {
            Pattern pattern = new Pattern();
            string expected = "true";
            string res = pattern.ValidatePassword("Vijayu@234");
            Assert.AreEqual(expected, res);
        }
    }
}