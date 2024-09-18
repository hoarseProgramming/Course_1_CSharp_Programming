//Path


string path = "C:\\Users\\hampu\\Programmering\\ITHS\\Kurser\\Kurs 1 - Programmering med C#\\SchoolCode\\README.md";

Console.WriteLine($"Path = {path}");

string newPath = Path.Combine("c:", "users", "hampu", "programmering", "test", "txt.txt");

Console.WriteLine($"NewPath => {newPath}");
//Returns full path
Console.WriteLine($"Path.GetFullPath => {Path.GetFullPath(newPath)}");
//Returns name of file(with extension) or folder
Console.WriteLine($"Path.GetFileName => {Path.GetFileName(newPath)}");
//Returns filename without extension
Console.WriteLine($"Path.GetFileNameWithoutExtension => {Path.GetFileNameWithoutExtension(newPath)}");
//Returns extension
Console.WriteLine($"Path.GetExtension => {Path.GetExtension(newPath)}");
//Returns path to directory
Console.WriteLine($"Path.GetDirectoryName => {Path.GetDirectoryName(newPath)}");
//Returns root in path
Console.WriteLine($"Path.GetPathRoot => {Path.GetPathRoot(newPath)}");
//Returns true if path exists
Console.WriteLine($"Path.Exists(newPath) => {Path.Exists(newPath)}");
Console.WriteLine($"Path.Exists(path) => {Path.Exists(path)}");
Console.WriteLine();
Console.WriteLine("*** Directory ***********");
Console.WriteLine();

Console.WriteLine($"Directory.GetCurrentDirectory = {Directory.GetCurrentDirectory()}");

string folderPath = Path.GetDirectoryName(newPath);
string[] files = Directory.GetFiles(folderPath);

foreach (string file in files)
{
    Console.WriteLine(Path.GetFileName(file));
}

string[] directories = Directory.GetDirectories(folderPath);

foreach (string directory in directories)
{
    Console.WriteLine(Path.GetFileName(directory));
}

string newFolder = Path.Combine(folderPath, "NewFolder", "Test1", "Test2");

//Creates directory if it doesn't exist
Directory.CreateDirectory(newFolder);


//Deletes empty directory
Directory.Delete(newFolder);