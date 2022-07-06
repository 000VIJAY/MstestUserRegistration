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
            bool result = pattern.ValidateFirstName("Vijay");
            bool expected = true;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void UserLastNameTest()
        {
            Pattern patt = new Pattern();
            bool expected = true;
            bool res = patt.validateLastName("Kumar");
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void UserEmailTest()
        {
            Pattern pattern = new Pattern();
            bool expected = true;
            bool result = pattern.validateEmail("Vijay@gmail.com");
            Assert.AreEqual(expected , result);
        }
    }
}