// // Input opration
// // to get Entier Line as String Input

// Console.Write("Enter name : ");
// var name = Console.ReadLine();

// Console.WriteLine($"Hello, {name}");

// // to get a number... (Little bit Complex to handel,,)
// // Since it takes the Entier Line need to handel based on that
// Console.Write("Enter a Number : ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine(num);


// // Explacit Handeling the Exception...
// // Better: TryParse (safer)
// Console.Write("Enter a number: ");
// string input = Console.ReadLine();

// if (int.TryParse(input, out int number))
//     Console.WriteLine($"You entered: {number}");
// else
//     Console.WriteLine("Invalid number!");



// // Read() - reads single character as ASCII code
// Console.Write("Enter any character :  ");
// int asciiCode = Console.Read();
// Console.WriteLine($"ASCII code: {asciiCode}");

string content = File.ReadAllText("output.txt");
Console.WriteLine(content);