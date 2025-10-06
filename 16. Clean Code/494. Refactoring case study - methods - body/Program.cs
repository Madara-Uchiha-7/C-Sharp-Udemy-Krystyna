
using System.Text.Json;

///
/// Let's now refactor the body of the method.
/// We will mostly focus on extracting small methods from a method that is too big.
/// This method is too long, does too many things, and mixes low-level operations like concatenating strings
/// with high-level operations like printing the method result to the console.
/// 
/// The first line handles a specific functionality for building a file path from its components.
/// It should certainly be moved to a method.
/// But notice how heavily this code relies on the FileIdentity type.
/// It clearly indicates that this functionality belongs to the FileIdentity struct and not here.
/// Let's place it where it belongs. We added AsPath () in the FileIdentity.
/// 

public class IdExistenceChecker
{
    private const string Txt = "txt";
    private const string Json = "json";

    public void CheckIfIdExistsInFile(int id, FileIdentity fileIdentity)
    {
        var filePath = fileIdentity.AsPath();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist under the path: " + filePath);
            return;
        }

        if (fileIdentity.Extension != Txt || fileIdentity.Extension == Json)
        {
            Console.WriteLine("Unsupported file extension: " + fileIdentity.Extension);
            return;
        }

        // We can pass the file path to below method, but since it will not get called many
        // times. So we will will again use the AsPath() in ReadIdsFromFile
        var idsFromFile = ReadIdsFromFile(fileIdentity);

        bool isIdPresentInFile = idsFromFile.Contains(id);
        PrintResult(isIdPresentInFile, id, filePath);
    }
    private static List<int> ReadIdsFromFile(FileIdentity fileIdentity)
    {
        // Reading data from txt or json file should be handled by different classes.
        // but since we focus now on refactoring methods,
        // we will keep the new methods in this class.
        var fileContent = File.ReadAllText(fileIdentity.AsPath());
        return fileIdentity.Extension == Txt ? 
                ReadIdsFromText(fileContent) :
                ReadIdsFromJson(fileContent);
    }
    private static List<int> ReadIdsFromText(string fileContent)
    {
        List<int> numbers = new List<int>();
        return fileContent
            .Split(",")
            .Select(fileId => int.Parse(fileId))
            .ToList();
    }
    private static List<int> ReadIdsFromJson(string fileContent)
    {
        return JsonSerializer.Deserialize<List<int>>(fileContent)!;
    }
    private void PrintResult(bool isIdPresentInFile, int id, string filePath)
    {
        var status = isIdPresentInFile ? "" : "not ";
        Console.WriteLine($"Id {id} has {status}been found in the file {filePath}.");
    }
}

public struct FileIdentity
{
    public string Directory { get; }
    public string Name { get; }
    public string Extension { get; }

    public FileIdentity(string directory, string name, string extension)
    {
        Directory = directory;
        Name = name;
        Extension = extension;
    }
    public string AsPath()
    {
        return Directory + "/" + Name + "." + Extension;
    }
}
