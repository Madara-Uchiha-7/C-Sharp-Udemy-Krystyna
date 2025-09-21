// We will refactor the code from lecture 87 in this lecture
Names names = new Names();
string path = names.BuildFilePath();
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
Console.WriteLine(names.Format());
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
class Names
{
    // Even thought the 'All' does not have the setter and we are initializing it while
    // delcaring the property, we can still modify 'All' from outside of the names class.
    // The lack of the setter only prevents us from assigning it a new value.
    // But we can modify its contents.
    // To avoid this we can use read only collection which will not allow us to modify the values.
    public List<string> All { get; } = new List<string>(); 
    private readonly NamesValidator _namesValidator = new NamesValidator();

    // Below method will call this class method called as the AddName
    // This is the recommended order when one method used another method.
    // If method A is calling the method B then the method A will be on the top of the method B.
    // One more rule is there is public methods should be above the private methods.
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
    public string BuildFilePath()
    {
        return "names.txt";
    }
    public string Format()
    {
        return string.Join(Environment.NewLine, All);
    }
}