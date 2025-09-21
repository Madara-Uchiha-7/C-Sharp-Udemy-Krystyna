/// <summary>
/// There are 5 principles called as SOLID
/// 1st is SRP.
/// It says:
/// Class should be responsible for only one thing.
/// or
/// Class should have only one reason to change.
/// For e.g. even though List class provides many diff methods and fields,
/// the main purpose of class List is to store the values in given order.
/// </summary>
// Single Responsibility Principle (SRP)
/* We will refactor below code in next lectures so that it matches SRP.
 * As you can see that below code works as a
 * Container for names.
 * It also checks how name should be validated.
 * Also it is reading from text file and writing in the text file.
 * Also building the path for the file.
 * Alos it is formating the list of names
 * one of the most imp principle in programming language i.e.SRP*/

Names names = new Names();
string path = names.BuildFilePath();
if (File.Exists(path))
{
    Console.WriteLine("Name file already exists. Loading names.");
    names.ReadFromTextFile();
}
else
{
    Console.WriteLine("Names file does not yet exists");

    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving user defined names in the file.");
    names.WriteToTextFile();
}
Console.WriteLine(names.Format());
Console.ReadKey();
class Names
{
    private List<string> _names = new List<string>();
    
    public void AddName(string name)
    {
        if (IsValid(name))
        {
            _names.Add(name);
        }
    }
    private bool IsValid(string name)
    {
        return name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
    public void ReadFromTextFile()
    {
        // ReadAllText() : reads the file from the path provided and puts in one
        // single string
        string fileContents = File.ReadAllText(BuildFilePath());
        // Split the string into list
        // New line char can be diff on diff operating systems.
        // Environment.NewLine property automatically uses new line char
        // according to the OS.
        List<string> namesfromFile = fileContents.Split(Environment.NewLine).ToList();
        // Adding the names in our _names list
        foreach (string name in namesfromFile)
        {
            AddName(name);
        }
    }
    public void WriteToTextFile()
    {
        // Format() : Format the list of names
        // as a single multiline string and then saves it to a text
        // file.
        File.WriteAllText(BuildFilePath(), Format());
    }
    public string BuildFilePath()
    {
        // In real word path will be right one
        // For now if only file name is given then it will be
        // created in the same directory in which the program is running.
        // You can right click on project and select open folder in file explorer
        // then go to bin->debug->new8.0-> here file will be created
        // because this is where the program runs, you can see .exe file.
        return "names.txt";
    }
    public string Format()
    {
        return string.Join(Environment.NewLine, _names);
    }
}

// Lets say you have been told to read and write the excel or db instead of text.
// Then there is a possibility that foramting will also change.
// Building the path will also change.
// Validation also may change