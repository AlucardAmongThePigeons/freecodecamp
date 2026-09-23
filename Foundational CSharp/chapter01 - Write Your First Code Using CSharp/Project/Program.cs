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
#pragma warning restore IDE0059 // Unnecessary assignment of a value
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
    int gameScore = 67;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
    decimal particlesPerMillion = 0.000001m;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
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