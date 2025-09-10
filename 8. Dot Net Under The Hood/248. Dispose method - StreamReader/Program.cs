// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// You will get below error for below code:
// System.IO.IOException:
// 'The process cannot access the file
// 'D:\Code\Udemy\C#\C# Krytina\8. Dot Net Under The Hood\248. Dispose method - StreamReader\bin\Debug\net8.0\test.txt'
// because it is being used by another process.'
// This is because
// the FileWriter still has the connection to this fire opened, even if it is done with writing to it.
// The SpecificLineFromTextFileReader class can not access this file because it is blocked.


const string filePath = "test.txt";
FileWriter fileWriter = new FileWriter(filePath);
fileWriter.Write("Hello1");
fileWriter.Write("Hello2");
fileWriter.Write("Hello3");
fileWriter.Write("Hello4");
fileWriter.Write("Hello5");
fileWriter.Write("Hello6");

SpecificLineFromTextFileReader reader = new SpecificLineFromTextFileReader(filePath);
string thirdLine = reader.ReadLineNumber(3);
string fourthLine = reader.ReadLineNumber(4);
Console.WriteLine($"The line number 3 and 4 data is {thirdLine},\n {fourthLine}");
Console.WriteLine("Press any key.");
Console.ReadKey();

public class FileWriter
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
}

public class SpecificLineFromTextFileReader
{
    private readonly StreamReader _reader;

    // Similarly, as the FileWriter class, it will take the file path as the constructor parameter.
    public SpecificLineFromTextFileReader(string path)
    {
        _reader = new StreamReader(path);
    }

    public string ReadLineNumber(int lineNumber)
    {
        // Reset the StreamReader's position to the beginning of the file
        // each time the ReadLineNumber method is called.
        // Below line empties the buffer of the stream reader and the second one moves the reader at the beginning
        _reader.DiscardBufferedData();
        _reader.BaseStream.Seek(0, SeekOrigin.Begin);
        // The stream reader exposes the ReadLine method.
        for (int i = 0; i < lineNumber - 1; i++)
        {
            _reader.ReadLine();
        }
        return _reader.ReadLine();
    }
}