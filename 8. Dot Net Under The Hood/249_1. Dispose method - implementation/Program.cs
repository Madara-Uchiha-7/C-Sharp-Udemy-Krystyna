///
/// Old syntax for using:
/// This code is simply a syntactic sugar for try and finally.
/// Means in try fileWriter.Write() statements will come i.e. the statements which is inside the using.
/// and in finally block will come fileWriter.Dispose()
/// 
/// Syntactic sugar is a feature in a programming language that makes the code easier to read or write,
/// but does not add any additional functionality.
/// It is called sugar because it is a small enhancement to the language that makes it more pleasant to
/// use but is not strictly necessary.
/// The example can be the using statement that will be translated to code in try and finally during the compilation.
/// Note: Using is working because we have implemented the IDisposable interface and implemented the dispose method.
/// Starting with C# 8 we can make this code shorter.
/// Lets see it in 
/// 249_2. Dispose method - implementation
///

const string filePath = "test.txt";
using (FileWriter fileWriter = new FileWriter(filePath))
{
    fileWriter.Write("Hello1");
    fileWriter.Write("Hello2");
    fileWriter.Write("Hello3");
    fileWriter.Write("Hello4");
    fileWriter.Write("Hello5");
    fileWriter.Write("Hello6");
}

string thirdLine = string.Empty;
string fourthLine = string.Empty;

using (SpecificLineFromTextFileReader reader = new SpecificLineFromTextFileReader(filePath))
{
    thirdLine = reader.ReadLineNumber(3);
    fourthLine = reader.ReadLineNumber(4);
}
Console.WriteLine($"The line number 3 and 4 data is {thirdLine},\n {fourthLine}");
Console.WriteLine("Press any key.");
Console.ReadKey();

public class FileWriter : IDisposable
{
    private readonly StreamWriter _streamWriter;

    public FileWriter(string path)
    {
        _streamWriter = new StreamWriter(path, true);
    }
    public void Write(string text)
    {
        _streamWriter.WriteLine(text);
        _streamWriter.Flush();
    }
    public void Dispose()
    {
        _streamWriter.Dispose();
    }
}

public class SpecificLineFromTextFileReader : IDisposable
{
    private readonly StreamReader _reader;

    public SpecificLineFromTextFileReader(string path)
    {
        _reader = new StreamReader(path);
    }

    public string ReadLineNumber(int lineNumber)
    {
        _reader.DiscardBufferedData();
        _reader.BaseStream.Seek(0, SeekOrigin.Begin);
        for (int i = 0; i < lineNumber - 1; i++)
        {
            _reader.ReadLine();
        }
        return _reader.ReadLine();
    }
    public void Dispose()
    {
        _reader.Dispose();
    }
}