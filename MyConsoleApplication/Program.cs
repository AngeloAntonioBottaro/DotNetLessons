// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

Console.WriteLine("**************************************");

var firstName = "Bob";
var messagesCount = 3;
float temperature = 34.4F; 
Console.Write($"Hello {firstName}! ");
Console.Write($"You have {messagesCount} messages in your inbox. ");
Console.WriteLine($"The temperature is {temperature} celsius.");

Console.WriteLine("**************************************");

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("**************************************");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.WriteLine("**************************************");