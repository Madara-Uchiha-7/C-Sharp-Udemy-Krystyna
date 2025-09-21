// DRY 
///
/// DRY is dont repeat any code principle.
/// But it should not be always used.
/// But its exact meaning is We should not have multiple places in the code
/// where the same business decisions are defined.
/// For eg: in Write() we are using string.Join(Sepearator, strings
/// and
/// in NameFormatter class Format we are using string.Join(Environment.NewLine, All);
/// where Sepearator is Environment.NewLine
/// The above eg. do have the same code but it does not break the DRY principle. 
/// Also we need to change the formating for the Names class only so it is better to not
/// conbine these 2 codes and add it in one method.
///
Names names = new Names();
string path = new NamesFilePathBuilder().BuildFilePath();
StringsTextualRepository stringsTextualRepository = new StringsTextualRepository();
if (File.Exists(path))
{
    Console.WriteLine("Name file already exists. Loading names.");
    List<string> stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exists");

    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving user defined names in the file.");
    stringsTextualRepository.Write(path, names.All);
}
Console.WriteLine(new NameFormatter().Format(names.All));
Console.ReadKey();
class NamesValidator
{
    public bool IsValid(string name)
    {
        return name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
}

class StringsTextualRepository
{
    private static readonly string Sepearator = Environment.NewLine;
    public List<string> Read(string filePath)
    {

        string fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Sepearator).ToList();
    }
    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Sepearator, strings));
    }
}

class NamesFilePathBuilder
{   public string BuildFilePath()
    {
        return "names.txt";
    }
}

class NameFormatter
{
    public string Format(List<string> names)
    {
        return string.Join(Environment.NewLine, names);
    }
}
class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();

    public void AddNames(List<string> stringsFromFile)
    {
        foreach (string name in stringsFromFile)
        {
            AddName(name);
        }
    }
    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            All.Add(name);
        }
    }
}