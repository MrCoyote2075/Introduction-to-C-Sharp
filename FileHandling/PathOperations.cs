using System.IO;

// 1. Combine paths (works on any OS)
string path = Path.Combine("MyFolder", "SubFolder", "file.txt");
// Windows : MyFolder\SubFolder\file.txt
// Linux   : MyFolder/SubFolder/file.txt

// 2. Get file name
string fileName = Path.GetFileName("C:\\MyFolder\\file.txt");
// Output: file.txt

// 3. Get file name without extension
string nameOnly = Path.GetFileNameWithoutExtension("file.txt");
// Output: file

// 4. Get extension
string ext = Path.GetExtension("file.txt");
// Output: .txt

// 5. Get directory name
string dir = Path.GetDirectoryName("C:\\MyFolder\\file.txt");
// Output: C:\MyFolder

// 6. Get full path
string fullPath = Path.GetFullPath("file.txt");
// Output: C:\CurrentDirectory\file.txt

// 7. Get temp path
string tempPath = Path.GetTempPath();

// 8. Create random file name
string randomFile = Path.GetRandomFileName();