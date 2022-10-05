Console.WriteLine("I'm going to help you create a password.");

Console.WriteLine("Please enter a phrase: ");
string? userPhrase = Console.ReadLine();

Console.WriteLine("Please enter a number greater than '9'");
string? userNumber = Console.ReadLine();

Console.WriteLine("Creating Password Now..\n");

string combinedInput = userPhrase + userNumber;
int numberLength = userNumber.Length - 1;
string firstDigit = userNumber.Substring(0,1);
string secondDigit = userNumber.Substring(numberLength,1);

combinedInput = combinedInput.Replace(" ", "");
combinedInput = combinedInput.Replace("a","z");
combinedInput = combinedInput.Replace("o","0");
combinedInput = combinedInput.Replace("i","!");
combinedInput = secondDigit + combinedInput;
combinedInput = combinedInput + firstDigit;

Console.WriteLine($"Original Phrase: {userPhrase}");
Console.WriteLine($"Original Number: {userNumber}");
Console.WriteLine($"New Password: {combinedInput}");

Console.ReadKey();