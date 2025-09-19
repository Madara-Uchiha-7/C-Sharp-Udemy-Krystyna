///
/// We will create a simple class that can load data from a CSV file.
/// I have kept the file in the same folder as the program.cs
/// 
/// When it comes to reading CSVs, there are some existing packages that can do it.
/// But as an exercise, let's create a basic CSV reader ourselves.
/// 
/// We will create a new type to represent a CSV file loaded into memory.
/// Lets name id CsvData.
/// We need to store the 2 types of information:
/// One about the columns and one about the rows of the table.
/// 
/// Each column is simply a collection of strings.
/// We could make it IEnumerable of string.
/// But the problem with enumerable is that it doesn't expose an indexer.
/// So, for example, we can't quickly and easily read the column at index 100.
/// That's why, we can make the columns property a simple array of strings.
/// 
/// Each row is a collection of strings, so each row could also be an array.
/// The collection of rows can be IEnumerable.
/// 
/// We will read the first line from the file.
/// The first line contains the column names, so we will split it by a comma, which will give an array
/// of strings.
/// 
/// Then we will keep reading the CSV file line by line.
/// 
/// Each line except the first contains a single row and we will also split them by commas.
/// The result of each split will be an array of strings representing a single row.
/// 
/// For simplicity, let's skip error handling.
/// We will assume the CSV files we read are always valid. To read the file
/// we will use the StreamReader class again. Since we want it properly disposed of
/// we will use the using statement.
/// 
/// Now after reading the column names, we want to keep reading lines until we reach the end of the file.
/// The StreamReader class exposes an EndOfStream property, which tells us if the end of the file has
/// been reached.
/// 
/// B is a special symbol in C#, strings used to escape other special characters.
/// So, for example, if we wanted our string to contain a quote character, we could not simply do
/// like: Console.WriteLine("hi "Chinmay", how are you");
/// 
/// Compiler treats the " as the start and end of the string.
/// To tell the compiler that this is an actual quote belonging to the string.
/// We can escape it using a backslash like this:
/// Console.WriteLine("hi \"Chinmay\", how are you");
///
/// But since the backslash has such special abilities, it is a special symbol itself.
/// So we can't use it here like this:
/// D:\Code\Udemy\C#\C# Krytina\8. Dot Net Under The Hood\251. Reading CSV files\sampleData.csv
/// 
/// We have a couple of choices.
/// First of all, we can escape it using a backslash, of course:
/// D:\\Code\\Udemy\\C#\\C# Krytina\\8. Dot Net Under The Hood\\251. Reading CSV files\\sampleData.csv
/// 
/// But even simpler, we can use the @ symbol we know already.
/// It interprets all characters within quotes, literally, except, of course, the quote itself.
/// Also, if we changed the backslashes to forward slashes, it would also work.
/// 
///

const string path = @"D:\Code\Udemy\C#\C# Krytina\8. Dot Net Under The Hood\251. Reading CSV files\sampleData.csv";

var csvReader = new CsvReader();
var data = csvReader.Read(path);

Console.ReadKey();


public class CsvReader
{
    public CsvData Read(string path)
    {
        using var streamReader = new StreamReader(path);

        const string seperator = ",";

        var columns = streamReader.ReadLine().Split(seperator);


        var rows = new List<string[]>();
        while(!streamReader.EndOfStream)
        {
            var cellValue = streamReader.ReadLine().Split(seperator);
            rows.Add(cellValue);
        }

        return new CsvData(columns, rows);
    }
}

public class CsvData
{ 
    public string[] Columns {  get; }
    public IEnumerable<string[]> Rows { get; }

    public CsvData(string[] columns, IEnumerable<string[]> rows)
    {
        Columns = columns; 
        Rows = rows;
    }
}
