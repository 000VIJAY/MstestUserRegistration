using UserRegistrationMstest;
Pattern GetPattern = new Pattern();

Console.WriteLine("Enter First Name");
string FN = Console.ReadLine();
GetPattern.ValidateFirstName(FN);

Console.WriteLine("Enter Last Name");
string LN = Console.ReadLine();
GetPattern.ValidateLastName(LN);

Console.WriteLine("Enter Email id ");
string Email_Id = Console.ReadLine();
GetPattern.ValidateEmail(Email_Id);

Console.WriteLine("Enter Phone number ");
string phoneNumber = Console.ReadLine();
GetPattern.ValidatePhoneNumber(phoneNumber);

Console.WriteLine("Enter Password ");
string passcode = Console.ReadLine();
GetPattern.ValidatePassword(passcode);

LambdaExpression valid = new();

Console.WriteLine("Enter First Name");
string FirstName = Console.ReadLine();
string res = valid.ValidateFirstName(FirstName);
Console.WriteLine(res);

Console.WriteLine("Enter Last Name");
string LastName = Console.ReadLine();
string result = valid.ValidateLastName(LastName);
Console.WriteLine(result);

Console.WriteLine("Enter Email");
string Email = Console.ReadLine();
string resultOne = valid.ValidateEmailId(Email);
Console.WriteLine(resultOne);

Console.WriteLine("Enter Phone Number");
string? PhoneNumber = Console.ReadLine();
string resultTwo = valid.PhoneNumber(PhoneNumber);
Console.WriteLine(resultTwo);

Console.WriteLine("Enter passcode");
string? passward = Console.ReadLine();
string resultThree = valid.ValidatePassword(passward);
Console.WriteLine(resultThree);