using UserRegistrationMstest;
Pattern GetPattern = new Pattern();
Console.WriteLine("Enter First Name");
string FN = Console.ReadLine();
Console.WriteLine(GetPattern.ValidateFirstName(FN));