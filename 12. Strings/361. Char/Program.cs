// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// Char represents a single character.
// It may be a single letter digit punctuation mark or any other single symbol.
// Some special chars need to be written using two symbols, even if they count as a single character in a string.
// e.g.
// For example, this is the case for the new line symbol.
char newLineSymbol = '\n';
// Remember that with characters, we use single quotes, not double quotes, like we do with strings.
// There are not many interesting methods we can call on the char instance.
// Instead, static methods from the char class can be used to manipulate characters.
// 

char lowerCaseLetter = 'a';
char upperCaseLatter = 'A';
char digitLetter = '1';


bool isUpperCase = Char.IsUpper(lowerCaseLetter);
bool isDigit = Char.IsDigit(digitLetter);

// For below line:
// Please notice that it includes Latin, Hebrew, Japanese, Korean, Chinese, Arabic and any other letters
// from the alphabets supported by char type.
bool isLetter = Char.IsLetter(digitLetter);

// Below will return true;
// Whitespace characters are all characters that occupy a place in the text but are not otherwise shown.
// They are characters like spaces, tabs or new lines.
bool isWhiteSpace =  Char.IsWhiteSpace(newLineSymbol);

// In bebug mode
// if you hover over the 
// toLowerCase after the execution of below line,
// you will see one number with it in the preview.
char toLowerCase = Char.ToLower(upperCaseLatter);

Console.ReadKey();

