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
        //test for Lambda 
        [TestMethod]
        public void FirstNameTestLambda()
        {
            LambdaExpression expression = new();
            string expected = "First Name is Valid";
            string res = expression.ValidateFirstName("Vijay");
            Assert.AreEqual(expected , res);
        }
        [TestMethod]
        public void LastNameTestLambda()
        {
            LambdaExpression expression = new();
            string expected = "Last Name is Valid";
            string res = expression.ValidateLastName("Kumar");
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void EmailTestLambda()
        {
            LambdaExpression expression =new();
            string expected = "Email is Valid";
            string res = expression.ValidateEmailId("Vijay@gmail.com");
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void PhoneNumberTestLambda()
        {
            LambdaExpression expression = new();
            string expected = "Phone Number is Valid";
            string res = expression.PhoneNumber("91 8847283564");
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void PasswordTestLambda()
        {
            LambdaExpression expression = new();
            string expected = "Password is Valid";
            string res = expression.ValidatePassword("Vijayu@234");
            Assert.AreEqual(expected, res);
        }
    }
}