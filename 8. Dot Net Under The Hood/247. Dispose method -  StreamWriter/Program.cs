// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// In this lecture, we will implement a class that writes to a file using the StreamWriter class.
// 

const string filePath = "test.txt";
// The file would be saved in the same folder from which the application runs.
// D:\Code\Udemy\C#\C# Krytina\8. Dot Net Under The Hood\247. Dispose method -  StreamWriter\bin\Debug\net8.0\test.txt
FileWriter fileWriter = new FileWriter(filePath);
fileWriter.Write("Hello");
Console.WriteLine("Press any key.");
Console.ReadKey();

public class FileWriter
{
    private readonly StreamWriter _streamWriter; // Predefinded class StreamWriter

    public FileWriter(string path)
    {
        _streamWriter = new StreamWriter(path, true);
        // true : if the new content written to the file will
        // be appended or if it will overwrite the existing content.
        // With this flag set to true, it will be appended.
    }
    public void Write(string text)
    {
        // The thing about the StreamWriter class is that it buffers the text we want to write.
        // It means it remembers it but does not write it to a file immediately.
        // To make it write what it remembers to the file and clear its buffer, we must call the Flush method.
        //
        _streamWriter.WriteLine(text);
        _streamWriter.Flush();
    }
}
