// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// We will learn how to use the Dispose method to free unmanaged resources.
// We will also understand what using statement is.
// And finally, we will learn what syntactic sugar is.
// 


using System.IO;

/// Right now we have a problem because FileWriter class opens the file connection to write to a file and it doesn't
/// close it.
/// This makes SpecificLineFromTextFileReader class crash when it tries to read from the same file because the file is blocked.
/// The solution is to make both of those classes implement the IDisposable interface.
/// This interface has a single method called Dispose.
/// We will also call it.
/// The file connections are closed once the Dispose method is called.
/// Calling the Dispose method like this works, but it is not a good practice.
/// Not only it is easy to forget about it, but even worse, if an exception is thrown in this code:
/// fileWriter.Write("..") or reader.ReadLineNumber(n);
/// then the dispose method will not be called and we wish it is called no matter what.
/// Because of this, it is better to use the using statement.
/// We will see that in 
/// 249_1. Dispose method - implementation
/// 

const string filePath = "test.txt";
FileWriter fileWriter = new FileWriter(filePath);
fileWriter.Write("Hello1");
fileWriter.Write("Hello2");
fileWriter.Write("Hello3");
fileWriter.Write("Hello4");
fileWriter.Write("Hello5");
fileWriter.Write("Hello6");
fileWriter.Dispose();

SpecificLineFromTextFileReader reader = new SpecificLineFromTextFileReader(filePath);
string thirdLine = reader.ReadLineNumber(3);
string fourthLine = reader.ReadLineNumber(4);
reader.Dispose();

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