using System.Text.Json;



var app = new GameDataParserApp();

// This Logger class is defined in another file.
var logger = new Logger("log.txt");
// Some of the most popular loggers are log4net and Serilog.
// If you are curious about log4net or Serilog:
// https://serilog.net/
// https://stackify.com/log4net-guide-dotnet-logging/

// Global try catch block
// If there is some exception, we did not predict it will be dealt with here anyway.
// So we will use Logger class here.
try
{
    app.Run();
}
catch(Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexpected error." +
        "and will have to closed.");

    logger.Log(ex);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

// You can format the whole code using : Ctrl + k + d
public class GameDataParserApp
{
    public void Run()
    {
        bool isFileRead = false;

        // From the type written before the variable name, compiler will assign the default value to that variable.
        // If you want to use "var" with "default" then do : var fileContents = default(string);
        string? fileContents = default;
        string? fileName = default;
        do
        {
            //try
            //{
                // If you add the JSON files in : bin\Debug\net8.0
                // then you do not need to give the whole path. Giving only file name work. This is what we have done.
                Console.WriteLine("Enter the name of the file you want to read: ");
                fileName = Console.ReadLine();


                // We can write all the if conditions in one single if
                // but then we will lose the ability to write the custom message 
                // for each condition.
                // We have commented the catch blocks
                // because same we can handle in if block.
                // Since this Run() method is called in the global try,
                // we do not have to worry about other unexpeceted exceptions. 
                if (fileName is null)
                {
                    // You can enter the null on console using ctl + z
                    Console.WriteLine("The file name can not be null.");
                }
                else if (fileName == string.Empty)
                {
                    Console.WriteLine("The file name can not be Empty.");
                }
                else if (!File.Exists(fileName))
                {
                    Console.WriteLine("File does not found.");
                }
                else
                {
                    fileContents = File.ReadAllText(fileName!);
                    isFileRead = true;
                }
            //}
            /*catch (ArgumentNullException ex)
            {
                // You can enter the null on console using ctl + z
                Console.WriteLine("The file name can not be null.");
            }
            catch (ArgumentException ex) // If file is empty
            {
                Console.WriteLine("The file name can not be Empty.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File does not found.");
            }*/
        }
        while (!isFileRead);

        List<VideoGame>? videoGames = default;

        try
        {
            videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {
            // We do not know that what will be color of the console of the user,
            // it will be decided at run time. So, instead of using the static value for color we will get
            // the current color of the console.
            var originalColor = Console.ForegroundColor;

            // Using below line we will change the color of the console.
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"JSON in {fileName} file was not " +
                $"in a valid format. JSON Body :");
            Console.WriteLine(fileContents);

            Console.ForegroundColor = originalColor;

            // We are not going to simply rethrow this exception here like this: throw;
            // Because it does not contain the file name. So, lets modify it.
            // We can't simply modify the message in the original exception.
            // Like ex.Message = "new message";
            // The Message property from Exception class is readonly.
            // "{ex.Message} The file is: {fileName}" will be appended at the end of the exception.
            // We also pass the original exception as the second parameter of the constructor, making it the inner
            // exception of the new object.
            // Throwing a brand new exception will result in resetting the stack trace, so the stack trace of
            // "new JsonException"
            // exception will point to :
            // throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
            // line, not :
            // videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            // one.
            // Keep in mind that we'll be logging the stack trace in the log file, but I don't think that resetting
            // the stack trace is a big problem here.
            // Stack trace pointing to below line will still help the developer investigating the issue.
            // Also, if this developer reproduces this catch block error and sees the exception in the debugger,
            // they will be able to see the stack trace of the original exception by checking the InnerException property.
            throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
        }
        if (videoGames.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Loded games are: ");
            foreach (var videoGame in videoGames)
            {
                Console.WriteLine(videoGame);
            }
        }
        else
        {
            Console.WriteLine("No games are present in the input file.");
        }
    }
}


public class VideoGame
{
    // We don't intend to modify the objects read from the file so we don't need settable properties.

    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }

    public override string ToString() =>
        $"{Title} released in {ReleaseYear}, rating: {Rating}";
}