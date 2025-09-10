// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// The underlying data structure of string is an array of chars.
// But this has interesting implications.
// We know that arrays have fixed sizes.
// So how does it happen that we can add new characters to a string?

string text = "abc";
text += "d";

// text += "d"; line may look like we modify the string, but as it turns out, we don't.
// A new string built by concatenating A, B, C with D is created and assigned to the text variable.
// All strings in C# are immutable.
// Every operation that seems to modify a string builds a new string.
// That's why the methods defined in the string class that we use to manipulate strings always return new strings.
// 


Console.ReadKey();