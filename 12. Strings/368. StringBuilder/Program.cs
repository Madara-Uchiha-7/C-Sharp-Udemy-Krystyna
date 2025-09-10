// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// A StringBuilder can add or remove pieces from the final string result, but without the laborious copying
// of the old string, adding a part and removing the old string.
// StringBuilder maintains a buffer to accommodate expansions to the string.
// New data is appended to the buffer if any space is left in it.
// Otherwise a new, larger buffer is allocated.
// In this case, data from the original buffer is copied to the new buffer and the new data is then appended.
// So the only scenario when the entire result is copied is when the buffer needs to be enlarged.
// 

using System.Diagnostics;
using System.Text;

// It comes from the System.Text namespace which needs to be imported.
StringBuilder stringBuilder = new StringBuilder();
// StringBuilder() : We can pass the capacity i.e. a count as the parameter to constructor.

const int Count = 200_000;
Stopwatch stop = Stopwatch.StartNew();
for (int i = 0; i < Count; i++)
{
    stringBuilder.Append("a");
}
stop.Stop();
Console.WriteLine(stop.ElapsedMilliseconds);
string text = stringBuilder.ToString();
// StringBuilder has more methods, like AppendLine, Clear, Replace etc.
// When the string built by this builder is ready, we can simply call the ToString method on the string
// builder object.

string text1 = string.Empty;
stop.Restart();
for (int i = 0; i < Count; i++)
{
    text1 += "a";
}
stop.Stop();
Console.WriteLine(stop.ElapsedMilliseconds);

Console.ReadKey();
// Look at the difference in execution time.
// O.p
// 6      : For StringBuilder it took only 6 mili seconds.
// 4698

// Of course, for simple use cases like concatenating a couple of strings, using the string builder is
// an overkill and it only complicates the code.
// StringBuilder is one of the most popular topics during C# interviews.
