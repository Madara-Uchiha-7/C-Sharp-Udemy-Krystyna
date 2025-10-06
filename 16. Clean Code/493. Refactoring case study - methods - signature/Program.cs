using System.Text.Json;

///
/// We renamed the method and class.
/// Now let's take a look at parameters.
/// Let's enclose those 3 parameters in a structure called file identity.
/// name, dir and ex
/// 
///
public class IdExistenceChecker
{
    public void CheckIfIdExistsInFile(int id, FileIdentity fileIdentity)
    {
        var file = fileIdentity.Directory + "/" + fileIdentity.Name + "." + fileIdentity.Extension;

        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist under the path: " + file);
            return;
        }
        List<int> numbers = new List<int>();
        if (fileIdentity.Extension == "txt")
        {
            var txt = File.ReadAllText(file);
            var ids = txt.Split(',');
            foreach (var fileId in ids)
            {
                numbers.Add(int.Parse(fileId));
            }
        }
        else if (fileIdentity.Extension == "json")
        {
            var txt = File.ReadAllText(file);
            numbers = JsonSerializer.Deserialize<List<int>>(txt);
        }
        else
        {
            Console.WriteLine("Unsupported file extension: " + fileIdentity.Extension);
            return;
        }
        foreach (var number in numbers)
        {
            if (number == id)
            {
                Console.WriteLine($"Id {id} has been found in the file {file}.");
                return;
            }
        }
        Console.WriteLine($"Id {id} has not been found in the file {file}.");
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
}

// We will refactor more in the next lecture code.