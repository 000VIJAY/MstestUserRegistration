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