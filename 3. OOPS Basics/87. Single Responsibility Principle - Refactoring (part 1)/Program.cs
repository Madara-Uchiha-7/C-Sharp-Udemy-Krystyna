// We will refactor the code from lecture 86 in this lecture
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
class NamesValidator
{
    // Method is pulbic so that we can use it in another class
    public bool IsValid(string name)
    {
        return name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
}

// Repositories are classes or components that are encapsulated the logic
// required to access the data sources.
// So we will include the word repository in our read and write method's class.
// We will also rename the methods of below class because the name of the
// below class explains what it will do.
class StringsTextualRepository
{
    // New Line for windows = "\n" for non windows = "\r\n"
    // We can not make below field const because the new line may change 
    // at depending on the OS. So, it is not fixed at the run time. 
    // Because this code's exe can be copied and run at any OS
    // So the Environment.NewLine will be decided at the runtime, so we can not
    // use const. We will keep it static so it will be same for n number of instances.
    // It will be readonly so no one can change it.
    // Since our method ReadFromTextFile uses Environment.NewLine.
    // We also made sure to use it in the WriteToTextFile() and we updated
    // WriteToTextFile() method according to it.
    // This will make sure of the consistency.
    // Our methods were using methods from Names class, so to tackle this
    // We added the parameters to our methods. Those parameters we can send from
    // Names class. Here also we kept the consistency that our maain Name class
    // is the only one who is creating the objects of these other classes.
    private static readonly string Sepearator = Environment.NewLine;
    public List<string> Read(string filePath)
    {

        string fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Sepearator).ToList();
        // We will put addition code which is in the for loop in different
        // class because this is differnt logic and our class should 
        // deal with the only one type of logic according to the SRP.
        // So, our method type is also changed form void to List<string>
        // for method ReadFromTextFile()
        /*foreach (string name in namesfromFile)
        {
            AddName(name);
        }*/
    }
    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Sepearator, strings));
    }
}
class Names
{
    private List<string> _names = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();
    public void AddName(string name)
    {
        // Notice how IsValid method name is not IsValidName()
        // Because our object name is enough to show that what this method will do.
        // Dont do new NamesValidator().IsValid()
        // Because this will create a new object each time when IsValid()
        // method will be called from Names class
        // I think we did not make NamesValidator class and its method static
        // because teacher has once told to avoid using static 
        if (_namesValidator.IsValid(name))
        {
            _names.Add(name);
        }
    }
    public string BuildFilePath()
    {
        return "names.txt";
    }
    public string Format()
    {
        return string.Join(Environment.NewLine, _names);
    }
}