
using System.Text.Json;

///
/// Let's now practice refactoring methods.
/// This lecture will show the method we will work on and discuss some of its issues.
/// Here is the method we will refactor.
///
public class FileManager
{
    public void IdFinder(string name, string dir, string ex, int id)
    {
        var file = dir + "/" + name + "." + ex;

        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist under the path: " + file);
            return;
        }
        List<int> numbers = new List<int>();
        if (ex == "txt")
        {
            var txt = File.ReadAllText(file);
            var ids = txt.Split(',');
            foreach (var fileId in ids)
            {
                numbers.Add(int.Parse(fileId));
            }
        }
        else if (ex == "json")
        {
            var txt = File.ReadAllText(file);
            numbers = JsonSerializer.Deserialize<List<int>>(txt);
        }
        else
        {
            Console.WriteLine("Unsupported file extension: " + ex);
            return;
        }
        foreach(var number in numbers)
        {
            if (number == id)
            {
                Console.WriteLine($"Id {id} has been found in the file {file}.");
                return;
            }
        }
        Console.WriteLine($"Id {id} has not been found in the file {file}.");
    }
}
///
/// Reading it quickly and understanding what it does from the code itself would be hard.
/// But I bet this method's name will help us grasp what this method does, won't it?
/// Well, it won't.
/// This name is rather weird being a noun, not a verb.
/// 
/// It seems this method finds some ID.
/// Maybe the parameters will tell us more than the method name itself.
/// Again, we can be disappointed.
/// There is some name, then "dir", which is most likely a directory.
/// Together, they probably built a path of some file.
/// There is also an "ex", which typically means an exception, but the type is string, not exception.
/// Finally, there is an ID parameter which is a bit odd.
/// 
/// We thought the whole purpose of this method was to find the ID, but it seems it takes it as a parameter.
/// The class name also doesn't help.
/// FileManager can be anything.
/// 
/// At this point, we only have one choice.
/// We need to read the method body carefully and ideally run it to see how it behaves.
/// 
/// This method checks whether the given ID is present in a specific file.
/// The path to this file is given in three parts.
/// We get the file name, the directory in which the file lives and the file extension, which can be TXT
/// or Json.
/// 
/// We use those three parts to build the file path.
/// Here we check if the file exists and if not, we print a proper message.
/// They are either text files in which numeric IDs are separated by commas or Json files with simple Json
/// arrays.
/// 
/// Depending on the file extension, we will read their contents differently.
/// But the goal is the same.
/// We want to build the list of IDs present in the file.
/// 
/// If the file has the txt extension, we read the text split by commas and then pass each id to a number.
/// If the file is Json, we use the JsonSerializer class.
/// Finally, once we have the list of IDs from the file, we iterate it and check if any of them equals
/// the ID given as an argument.
/// 
/// If so, we print the message saying that the ID has been found and we stop the method execution.
/// If not, we also print a proper message.
/// 
/// Let's think about how to refactor this method in the next lecture.
/// 
/// 
///