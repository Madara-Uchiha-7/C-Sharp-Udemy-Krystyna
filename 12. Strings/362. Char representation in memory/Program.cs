// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


char newLineSymbol = '\n';
char lowerCaseLetter = 'a';
char upperCaseLatter = 'A';
char digitLetter = '1';
// In debug more 
//hover over the characters we created.
// As you can see in the preview, each character follows an integer.
// To understand why that is so, we must understand how characters are represented in memory.
// In C# each character occupies 16 bits of memory, which means it is a sequence of 16 zeros and ones.
// Such a sequence can easily be interpreted as a number.
// After all, the integer is also a sequence of zeros and ones.
// In C#, int occupies 32 bits of memory, so it can store larger numbers. On 16 bits
// we can store numbers up to a bit more than 65,000, which means in C# we can have over 65,000 different
// characters.
// Since the internal representation of a character can be interpreted as int, we can easily cast chars
// to ints and vice versa.
char someChar = (char)100;
int someInt = (int)'t';
// For above 2 lines, use the debugger to see the values of those variables.
// As you can see, the number 100 maps to the lowercase D character.
// The integer representation of the lowercase 't' is number 116.
// We can even increment characters just as numbers.
// Let's write a loop that prints all characters between uppercase A and lowercase Z.
for (char c = 'A'; c < 'z'; c++)
{
    Console.Write(c + "-");
}
// So each char can be interpreted as a number, which means there must be some mapping defining what number
// matches what character.
// Such mapping is called encoding.
// We saw it already when we saw that number 100 maps to lowercase 'd' and 116 to lowercase 't'. But who defines
// this mapping?
// Well, it's all a matter of standardization.
// The main organization for standardizing the usage of characters in computing is called Unicode.
// It defines many standards, and the one used with C# characters is called UTF 16, which means
// 16 bit Unicode Transformation Format.
// Link for all the numeric codes for all the characters:
// https://www.ssec.wisc.edu/~tomw/java/unicode.html

// What is important to understand UTF 16 is not the only encoding there is.
// 

Console.ReadKey();