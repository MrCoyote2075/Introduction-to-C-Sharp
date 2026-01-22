
// Other Operations....

// 0. Check if file exists
if (File.Exists("myfile.txt"))
    Console.WriteLine("File exists!");
else
    Console.WriteLine("File not found!");


// 1. Copy file
File.Copy("source.txt", "destination.txt");

// Copy with overwrite
File.Copy("source.txt", "destination.txt", overwrite: true);

// 2. Move/Rename file
File.Move("oldname.txt", "newname.txt");

// 3. Delete file
File.Delete("target.txt");

// 4. Get file info
FileInfo info = new FileInfo("myfile.txt");
Console.WriteLine($"Size: {info.Length} bytes");
Console.WriteLine($"Created: {info.CreationTime}");
Console.WriteLine($"Modified: {info.LastWriteTime}");
Console.WriteLine($"Extension: {info.Extension}");
Console.WriteLine($"Name: {info.Name}");
Console.WriteLine($"Full path: {info.FullName}");


/// Directory Operations
// Working with Directories

// 1. Create directory
Directory.CreateDirectory("MyFolder");
Directory.CreateDirectory("Parent/Child/GrandChild");  // Creates all even if Not Found...

// 2. Check if directory exists
if (Directory.Exists("MyFolder"))
    Console.WriteLine("Directory exists!");

// 3. Get current directory name
string currentDir = Directory.GetCurrentDirectory();
Console.WriteLine($"Current: {currentDir}");

// 4. Get files name in the Given directory
string[] files = Directory.GetFiles("MyFolder");
foreach (string file in files)
    Console.WriteLine(file);

// Get files name with (regex) pattern in the given directory
string[] txtFiles = Directory.GetFiles("MyFolder", "*.txt");

// 5. Get subdirectories for the given Directory
string[] subdirs = Directory.GetDirectories("MyFolder");

// 6. Get all files and folders name for the given directory
string[] allEntries = Directory.GetFileSystemEntries("MyFolder");

// 7. Delete given directory
Directory.Delete("MyFolder");  // Must be empty

// Delete with contents
Directory.Delete("MyFolder", recursive: true);

// 8. Move/Rename directory
Directory.Move("OldFolder", "NewFolder");