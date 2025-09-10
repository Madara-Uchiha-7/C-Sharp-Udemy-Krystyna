// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// In this lecture, we will understand what problems can be caused by an incremental building of large
// strings.
// We know now that strings are immutable.
// So each time they are seemingly modified, a new string is created under the hood, replacing the old
// This actually may be quite problematic.
// Lets say a simple loop builds a string made of 1000 letters. 

const int Count = 100;

string text = string.Empty;

for (int i = 0; i < Count; i++)
{
    text += "a";
}
// Let's consider what happens under the hood, keeping in mind that strings
// In the first iteration, the text is assigned a string made of a single letter.
// A In the second, a new string is built out of the old string plus the additional letter A. In the third,
// it is similar.
// A new string is built using those two strings.
// So each time we seemingly modify the string, the following things need to happen.
// A new string object needs to be created which involves allocating memory for it.
// The variable that was pointing to the original string must be pointed to the new string.
// At some point the garbage collector must clean up the old string.
// That's a lot of work.
// In many cases it's not a problem and we don't notice any performance impact when we add "Mr." to the "John"
// But here we do it gradually in a loop.
// And this is not unusual.
// For example, imagine your application is downloading some data from the web and it does it in chunks
// as the data is pretty large.
// We want to build some extract of this data. For each chunk read, and there can be thousands of them,
// we will need to build some pretty complex string and then append it to the string representing the final
// result.
// It can involve millions of concatenation operations. As the process continues, the final result grows.
// At some point it can be a huge string and still every concatenation keeps copying it to a new huge part
// of memory, adding some tiny part and then replacing the reference stored in the original variable.
// Not to mention that behind the scenes the garbage collector is struggling to clean up all those large
// unused strings.
// This is certainly not optimal. For cases like this the StringBuilder class has been created.

Console.ReadKey();