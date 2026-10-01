#region Basics of console printing
{
    Console.Write("Console.Write() will write a string without appending a new line");
    Console.WriteLine(", while Console.WriteLine() will put a new line in the end");
    Console.WriteLine();
}
#endregion


#region Litteral values
{
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
}
#endregion


#region Variables
{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
    char userOption = 'y';
    int gameScore = 67;
    decimal particlesPerMillion = 0.000001m;
    bool processedCustomer = false;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
#pragma warning restore CS0219 // Variable is assigned but its value is never used

    string firstName;
    firstName = "Mauro";
    Console.WriteLine("This was in a string variable called firstName: " + firstName);
    firstName = "Liem";
    Console.WriteLine("updated string variable called firstName with value: " + firstName);
}
#endregion


#region Implicity typed local variables
{
    /* An implicitly typed local variable is created by using the var keyword followed by a variable initialization. For example:
    C# */

#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
    var message = "Hello world!";
#pragma warning restore IDE0059 // Unnecessary assignment of a value
#pragma warning restore CS0219 // Variable is assigned but its value is never used

    /* The var keyword tells the C# compiler that the data type is implied by the assigned value.
    After the type is implied, the variable acts the same as if the actual data type had been used to declare it.
    The var keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context. */
}
#endregion


#region module 2 challange
{
    // Nota: avendo isolato il blocco sopra, qui possiamo ridichiarare "string firstName"
    // invece di riutilizzare quella del blocco precedente.
    string firstName = "Bob";
    int inboxCount = 3;
    float weatherTemperature = 26.7f;

    Console.WriteLine($"Hello, {firstName}! You have {inboxCount} messages in your inbox. The temperature is {weatherTemperature}° celsius.");
}
#endregion


#region Create string data containing tabs, new lines, and other special characters
{
    Console.WriteLine("Hello\nWorld!");
    Console.WriteLine("Hello\tWorld!");
    Console.WriteLine("Hello \"World\"!");
    Console.WriteLine("c:\\source\\repos");


    Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
    Console.WriteLine("Invoice: 1021\t\tComplete!");
    Console.WriteLine("Invoice: 1022\t\tComplete!");
    Console.Write("\nOutput Directory:\t");

    // Verbatim string literal

    Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
    Console.Write(@"c:\invoices");

    /*
    Here's what you've learned about formatting literal strings so far:

        Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
        Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
        Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
    */
}
#endregion


#region Create string data containing Unicode characters
{
    // unicode escap echaracters
    // Kon'nichiwa World
    Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

    // To generate Japanese invoices:
    // Nihon no seikyū-sho o seisei suru ni wa:
    Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
    // User command to run an application
    Console.WriteLine(@"c:\invoices\app.exe -j");

    /*
    Here's what you've learned about formatting literal strings so far:

        Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
        Unicode characters may not print correctly depending on the application.
    */
}
#endregion


#region Combine string data into a new string value via concatenation
{
    {
        string firstName = "Bob";
        string message = "Hello " + firstName;
        Console.WriteLine(message);
    }

    {
        string firstName = "Bob";
        string greeting = "Hello";
        string message = greeting + " " + firstName + "!";
        Console.WriteLine(message);
    }

    {
        string firstName = "Bob";
        string greeting = "Hello";
        Console.WriteLine(greeting + " " + firstName + "!");
    }

    /*
    Here's what you've learned about string concatenation so far:

        String concatenation allows you to combine smaller literal and variable strings into a single string.
        Avoid creating intermediate variables if adding them doesn't increase readability.
    */
}
#endregion


#region Combine string data into a new string value via interpolation
{
    {
        string firstName = "Bob";
        string greeting = "Hello";

        {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            string message = greeting + " " + firstName + "!";
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }

        // can be written with string interpolation as this:

        {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            string message = $"{greeting} {firstName}!";
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }
    }

    {
        string firstName = "Bob";
        string message = $"Hello {firstName}!";
        Console.WriteLine(message);
    }

    {
        int version = 11;
        string updateText = "Update to Windows";
        string message = $"{updateText} {version}";
        Console.WriteLine(message);
    }

    {
        int version = 11;
        string updateText = "Update to Windows";
        Console.WriteLine($"{updateText} {version}!");
    }

    // you can combine verbatim literals and string interpolation @$
    {
        string projectName = "First-Project";
        Console.WriteLine($@"C:\Output\{projectName}\Data");
    }

    /*
        Here's what you've learned about string interpolation so far:

        String interpolation provides an improvement over string concatenation by reducing the number of characters required in some situations.
        You can combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.
    */
}
#endregion

#region Module 2 challange 1
{

    string projectName = "ACME";
    string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

    Console.WriteLine(
@$"View English output:
    c:\Exercise\{projectName}\data.txt
            
{russianMessage}:
    c:\Excercise\ru-RU\{projectName}\data.txt
"
);
}
#endregion

#region Recognize C#'s common numeric data types
{
    /*
    Type Name 	C# Keyword 	Description 	                                    Example
    Integer 	int 	    Whole numbers (positive or negative) 	            42, -7, 1000
    Decimal 	decimal 	Precise decimal numbers, great for money 	        19.99m, 3.14m
    Double 	    double 	    Larger decimal numbers, common for calculations 	3.14, 2.71828
    */

    {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int score = 95;
        decimal price = 19.99m;
        double average = 87.5;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
    }

    {
        int a = 7;
        int b = 2;
        Console.WriteLine(a / b);        // Output: 3 (integer division truncates)

        decimal c = 7m;
        decimal d = 2m;
        Console.WriteLine(c / d);        // Output: 3.5 (keeps the decimal)
    }


}
#endregion

#region Perform basic math operations with numbers
{
    /*
        Operator 	Action 	                Example 	Result
        + 	        Addition 	            10 + 3 	    13
        - 	        Subtraction 	        10 - 3 	    7
        * 	        Multiplication 	        10 * 3 	    30
        / 	        Division 	            10 / 3 	    3 (integer division)
        % 	        Modulus (remainder) 	10 % 3 	    1
    */

    {
        // The modulus operator % returns whatever is left over after division:
        Console.WriteLine(10 % 2);   // Output: 0 (10 is even)
        Console.WriteLine(11 % 2);   // Output: 1 (11 is odd)
    }

    {
        // C# follows standard math order of operations (PEMDAS): Parentheses, then Multiplication/Division, then Addition/Subtraction.
        // Use parentheses to control the order:

#pragma warning disable
        int standard = 2 + 3 * 4;      // Multiplication first: 14
        int forced = (2 + 3) * 4;      // Parentheses first: 20
#pragma warning restore
    }

    {
        // A common pattern is updating a variable using its own value—like adding to a score or subtracting from a balance. C# has shorthand operators for this:

        int score = 50;
        score = score + 10;    // Standard way: score is 60
        score += 10;           // Shorthand: score is 70

        // The same shorthand works for other operations:
        // Operator 	Meaning 	            Example         Result (starting at 10)
        // += 	        Add and assign 	        x += 5 	        15
        // -= 	        Subtract and assign     x -= 5 	        5
        // *= 	        Multiply and assign     x *= 5 	        50
        // /= 	        Divide and assign 	    x /= 5 	        2
    }

    {
        // For adding or subtracting 1, C# has even shorter operators—++ and --:

        int count = 5;
        count++;                       // Same as count = count + 1
        Console.WriteLine(count);      // Output: 6

        count--;                       // Same as count = count - 1
        Console.WriteLine(count);      // Output: 5
    }

    {
        // The ++ and -- operators behave differently depending on whether they appear before or after the variable:

        //  Post-increment (value++): Uses the current value first, then increments
        //  Pre-increment (++value): Increments first, then uses the new value

        int a = 5;
        Console.WriteLine(a++);   // Output: 5 (uses old value, then increments)
        Console.WriteLine(a);     // Output: 6 (a was incremented)

        int b = 5;
        Console.WriteLine(++b);   // Output: 6 (increments first, then uses new value)
        Console.WriteLine(b);     // Output: 6

        // The same rules apply to -- (decrement).
    }

    {
        {
            // When you divide two integers, C# truncates (drops) the decimal portion:
            int result = 7 / 2;
            Console.WriteLine(result);     // Output: 3 (not 3.5)
        }

        {
            // To keep the decimal, at least one of the numbers must be a decimal type:
            decimal result = 7m / 2m;
            Console.WriteLine(result);     // Output: 3.5
        }

        // This is why choosing the right data type matters for your calculations. In the next section, you learn how to convert between types when you need to.
    }
}
#endregion

#region Convert values between different data types
{
    // C# provides Convert methods to change values between data types:
    // Method 	            Converts to 	Example 	                Result
    // Convert.ToInt32() 	int 	        Convert.ToInt32("42") 	    42
    // Convert.ToDecimal() 	decimal 	    Convert.ToDecimal("19.99") 	19.99m
    // Convert.ToDouble() 	double 	        Convert.ToDouble("3.14") 	3.14
    // Convert.ToString() 	string 	        Convert.ToString(42) 	    "42"

    {
        Console.Write("Enter your age: ");
        string? ageInput = Console.ReadLine();
        int age = Convert.ToInt32(ageInput);
        int nextYear = age + 1;
        Console.WriteLine($"Next year you'll be {nextYear}");
    }

    {
        // Another way to convert strings to numbers is with the Parse methods:
        int age = int.Parse("25");
        decimal price = decimal.Parse("19.99");
        double average = double.Parse("87.5");
        // Both Convert.ToInt32() and int.Parse() do similar things—use whichever style you prefer.
    }

    {
        // To convert between numeric types (like decimal to int), use a cast by placing the target type in parentheses:

        decimal price = 19.99m;
        int wholePrice = (int)price;         // Casts to int: 19 (decimal dropped)
        Console.WriteLine(wholePrice);       // Output: 19

        // You can also cast to keep decimal precision during division:

        int first = 7;
        int second = 2;
        decimal result = (decimal)first / (decimal)second;
        Console.WriteLine(result);           // Output: 3.5

        // What happens with invalid conversions?

        // If you try to convert a value that can't be interpreted as a number, C# throws an error:

        // int number = Convert.ToInt32("hello");    // ERROR: Input string was not in a correct format

        // For now, just make sure the value can be converted before you try. Later, you'll learn how to handle errors gracefully.
    }
}
#endregion

#region Exercise: Build a tip calculator
{
    // Collect the bill amount and tip percentage
    const int minTip = 10, maxTip = 100;
    double billAmount, tipAmount, total;
    int tipPercentage;
    bool success;

    do
    {
        Console.Write("Insert bill amount [must be a decimal number greater than 0]: ");
        string? input = Console.ReadLine();
        success = double.TryParse(input, out billAmount);
    } while (!success || billAmount <= 0);

    do
    {
        Console.Write($"Insert tip percentage [must be an integer between {minTip} and {maxTip}]: ");
        string? input = Console.ReadLine();
        success = int.TryParse(input, out tipPercentage);
    } while (!success || tipPercentage < minTip || tipPercentage > maxTip);

    // Display the entered values
    Console.WriteLine();
    Console.WriteLine($"Bill amount: {billAmount:C}");
    Console.WriteLine($"Tip percentage: {tipPercentage}%");

    // Calculate the tip and total
    Console.WriteLine("Calculating tip amount and total");
    tipAmount = billAmount * (tipPercentage / 100.0);
    total = billAmount + tipAmount;

    // Display the results
    {
        string billStr = billAmount.ToString("C");
        string tipStr = tipAmount.ToString("C");
        string totalStr = total.ToString("C");
        Console.WriteLine();
        Console.WriteLine($"{"Price".PadRight(15, '.')}{billStr.PadLeft(10, '.')}");
        Console.WriteLine($"{"Tip".PadRight(15, '.')}{tipStr.PadLeft(10, '.')}");
        Console.WriteLine();
        Console.WriteLine($"{"Total".PadRight(15, '.')}{totalStr.PadLeft(10, '.')}");
        Console.WriteLine();
    }
}
#endregion

