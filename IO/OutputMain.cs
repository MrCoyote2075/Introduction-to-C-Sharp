// Output (without newLine)
Console.Write("Hello");
Console.Write(" World");

// output With Newline At last..
Console.WriteLine(" , this is dhanu...");
Console.WriteLine("Your Guider...");


// String Concatination..
Console.WriteLine("Concatination " + "using" + " Plus");


// Two Style of  Variable Usage in output...

// Scanf() Style implementation using '{ index-of-the-variable }'..
var name = "Dhanu";
var age = 20;
var gender = "Male";

Console.WriteLine("Name: {0}, Gender: {2}, Age: {1}", name, age, gender);


// Expression Style using '$' in front of String, and '{ variable-name }'

Console.WriteLine($"Name: {name}, \nAge: {age}, \nGender: {gender}");


// Formating the Numbers...
double price = 1234.5678;

// Currency:  ₹ 1,234.57
Console.WriteLine($"Price: {price:C}");      

// 2 decimals: 1234.57
Console.WriteLine($"Price: {price:F2}");     

// Number format: 1,234.57
Console.WriteLine($"Price: {price:N}");      



// Number Convertion...
int number = 12;

// Convert to Binary Number...
Console.WriteLine($"Binary Format: {number:B}");

// Convert to Hexadecimal...
Console.WriteLine($"Hex Format: {number:X}");  

// Zeros Padding (Adding Zeros in front)...
Console.WriteLine($"Padded: {number:D5}"); 



// Changing the Console Color... 
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Hello World!");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Hello Every One, ");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("This is Dhanu...");

// this Reverts Color Settings Only...
Console.ResetColor();

// to Clear Console Screen Completly...
// Console.Clear();