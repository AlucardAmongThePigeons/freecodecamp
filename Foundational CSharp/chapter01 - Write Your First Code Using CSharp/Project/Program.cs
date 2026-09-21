// Basics of console printing

Console.Write("Console.Write() will write a string without appending a new line");
Console.WriteLine(", while Console.WriteLine() will put a new line in the end");
Console.WriteLine();


// Litteral values

Console.Write("This is a char litteral: ");
Console.WriteLine('z');

Console.Write("This is a int litteral: ");
Console.WriteLine(123);

Console.WriteLine(
@"
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
");

Console.Write("This is a float litteral: ");
Console.WriteLine(0.25f);

Console.Write("This is a double litteral: ");
Console.WriteLine(2.625);

Console.Write("This is a decimal litteral: ");
Console.WriteLine(12.39816m);

Console.Write("Those are boolean litterals: ");
Console.Write(true);
Console.Write(", ");
Console.WriteLine(false);


// Variables

char userOption = 'y';
int gameScore = 67;
decimal particlesPerMillion = 0.000001m;
bool processedCustomer = false;

string firstName;
firstName = "Mauro";
Console.WriteLine("This was in a string variable called firstName: " + firstName);
firstName = "Liem";
Console.WriteLine("updated string variable called firstName with value: " + firstName);


// Implicity typed local variables

/* An implicitly typed local variable is created by using the var keyword followed by a variable initialization. For example:
C# */

var message = "Hello world!";

/* The var keyword tells the C# compiler that the data type is implied by the assigned value.
After the type is implied, the variable acts the same as if the actual data type had been used to declare it.
The var keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context. */


// challange

firstName = "Bob";
int inboxCount = 3;
float weatherTemperature = 26.7f;

Console.WriteLine($"Hello, {firstName}! You have {inboxCount} messages in your inbox. The temperature is {weatherTemperature}° celsius.");

