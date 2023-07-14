Console.WriteLine("Welcome to the Greeting Application.");
Console.WriteLine("This Application was built by Héctor Sandoval.");
Console.WriteLine("------------------------------------------");
Console.WriteLine();
Console.Write("What is your name: ");
string userName=Console.ReadLine();
Console.WriteLine($"Hello {userName}");
Console.WriteLine("Thank you for using my application.");

string firstName = string.Empty;
string lastName = string.Empty;
string fullName = "";



firstName = "Héctor";
lastName = "Sandoval";
// $ is for string interpolation
fullName = $"{ firstName } {lastName}";

string fileName = "";
// @ is for string literals
fileName = @"c:\Temp\Test.txt";

string testString = $@"The file for {firstName} is at c:\SampleFiles";
Console.WriteLine(testString);

string zipCode = "084054";
string phoneNumber = "3313964038";

//Whole number
int age = 0;
age = 10;

int numberOfApplesTotal = 450;
int numberOfApplesIAte = 4;

Console.WriteLine(numberOfApplesTotal-numberOfApplesIAte);

//Use double for all numbers that includes fractions except for money
double averageWordsPerMinute = 34.24;
//Use decimal for Money
decimal costPerContainer = 43.85M;
Console.WriteLine(costPerContainer);

bool isAlive = false;


Console.WriteLine(fullName);
