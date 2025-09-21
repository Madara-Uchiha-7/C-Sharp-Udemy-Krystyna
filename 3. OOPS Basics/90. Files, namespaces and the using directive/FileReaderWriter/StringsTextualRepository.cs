namespace _90._Files__namespaces_and_the_using_directive.FileReaderWriter;
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


