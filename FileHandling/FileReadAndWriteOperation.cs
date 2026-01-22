using System.IO;

//          File Writing
// Method 1: WriteAllText( String )
// Write text to file (creates or overwrites)
string content = "Hello, this is my first file!";
File.WriteAllText("myfile.txt", content);

Console.WriteLine("File created!");


// Method 2: WriteAllLines ( String Array )
string[] lines = {
    "Line 1: Hello",
    "Line 2: World",
    "Line 3: C# is awesome!"
};

File.WriteAllLines("lines.txt", lines);


//  Method 3: AppendAllText ( String )
// Appends to file without overwriting
string newContent = "\nThis is a new line! ";
File.AppendAllText("myfile.txt", newContent);



// Method 4: StreamWriter ( String - FileName )
// Writing with StreamWriter
using (StreamWriter writer = new StreamWriter("output.txt")) {
    writer.WriteLine("First line");
    // Any other Oprations...
    writer.WriteLine("Second line");
    // Any other Oprations...
    writer.Write("No newline");
}  // Atlast Auto-closes the file

// Append mode - Same as the Writer functions
using (StreamWriter writer = new StreamWriter("output.txt", append: true)) {
    writer.WriteLine("Appended line");
}


// File Reading Oprations

// Method 1: ReadAllText ( String -> FileName ) -> String
// Read entire file as one string
content = File.ReadAllText("myfile.txt");
Console.WriteLine(content);


// Method 2: ReadAllLines ( String -> FileName ) -> Array of Lines

// Method 3: ReadLines (Memory Efficient - IEnumerable)
// Read file as array of lines
// Without Explicitly Storing in variable and Directly using it in ForEach() 
// is Good for large files - reads line by line
foreach (string line in File.ReadLines("myfile.txt"))
    Console.WriteLine(line);
