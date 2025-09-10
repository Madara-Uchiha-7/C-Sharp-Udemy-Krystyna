// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Let's say I want to print the Greek letter Omega in my application.
// We copied it from our link:
// https://www.ssec.wisc.edu/~tomw/java/unicode.html

using System.Text; // For Console.OutputEncoding = Encoding.Unicode;  The encoding type comes from the System.Text

char omega = 'Ω'; // 937 is the number for this.
Console.WriteLine(omega);
Console.WriteLine((int)omega);
// There is a possibility that other character may get printed instead of omega.
// It is working on my machine but not on teachers.

Console.WriteLine(Console.OutputEncoding);
// Above line will give
// System.Text.OSEncoding
// It means it's using the current encoding of the operating system of my computer.
// While debugging if you quick watch Console.OutputEncoding
// then you will see Encoding Name. 
// Teacher's encoding name is Codepage - 852.
// The Code page 852 encoding is used when the operating system is set to support some central European
// languages like Hungarian, Polish or Romanian.
// This specific encoding supports much fewer characters than UTF 16.
// It simply does not contain the character for the Greek letter Omega, so it couldn't be printed to the
// console. To make it work
// To make it work 
// we can tell the console class to use UTF 16 encoding.
// You can do that using below line:
// Console.OutputEncoding = Encoding.Unicode;
// The encoding type comes from the System.Text namespace which needs to be imported.

// Please notice that some other characters may still not work.
// Find some Arabic letters.
// Try to print 1583
// It will possibly print a question mark, but this time it is not the fault of the wrong encoding.
// The reason is that the font we use in the console simply doesn't support Arabic letters.
// We would need to install a proper font and change it in the console settings.
Console.ReadKey();

// Some popular encodings are:
// UTF-8
// UTF-16
// ASCII
// Code Page 852
// and more
