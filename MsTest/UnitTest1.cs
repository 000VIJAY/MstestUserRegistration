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
    }
}