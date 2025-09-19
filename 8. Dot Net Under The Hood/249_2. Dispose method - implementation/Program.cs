///
/// New syntax:
/// This way we don't need braces and the Dispose method will simply be called at the end of the scope of
/// reader variable.
/// We have not used this new syntax with filerWriter because,
/// we need to dispose it before we start reading from the file. 
/// With braces the Dispose method is simply called at the end of the scope they define.
/// 
/// Before we wrap up, here are a couple of comments about the Dispose method.
/// Remember that the garbage collector does not call the Dispose method.
/// We must call it ourselves.
/// And the best way to do it is by using the using statement.
/// Some people habitually add a finalizer to their class in which they call the Dispose method.
/// For e.g. check code
/// ~FileWriter()  {...}
/// The reasoning behind it is that if one forgets to call the Dispose method, most likely because they
/// didn't use the using statement, the Dispose method will be called in the finalizer.
/// But this is an attempt to solve a problem that shouldn't exist.
/// Not to mention that, as we said in the lecture about finalizers, we don't get a guarantee that they
/// will be called.
/// If your class will be inherited from it should implement the Dispose method
/// in a special way.
/// This topic is quite advanced, so I think we can skip it, especially since inheritance is not used
/// very often.
/// If you are curious, then link is:
/// https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/dispose-pattern
/// 
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

using SpecificLineFromTextFileReader reader = new SpecificLineFromTextFileReader(filePath);
thirdLine = reader.ReadLineNumber(3);
fourthLine = reader.ReadLineNumber(4);


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
    /*
    ~FileWriter() 
    { 
        Dispose();
    }
    */
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