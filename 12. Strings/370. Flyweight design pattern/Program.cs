// -- Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// Let's start with an example of a program in which this design pattern could be useful.
// This program is a text editor that prints words on the screen.
// As with most text editors, it allows font customization even for a single character.
// But this is rare to have each character in a text document utilize a different font.
// Sure, some characters may be bold and some may use some fancy font, but overall most will use exactly
// the same font.
// Since font can be different for each char, we should have a separate object describing the font for
// each and every character in the document.
// This object would contain quite a lot of data.
// e.g. if there is a word : "test"
// then each letter i.e. t, e, s, t
// will have their own, Font, Size, IsBold, IsItalic etc..
// If it is a long book, and you will see that the memory consumption of such a program
// could be immense.
// Most of the characters in the text will have identical objects describing them.
// Only some of them will be bold, italic or have larger size.
// So instead of having hundreds of thousands of very similar objects, let's only have one object storing
// the information about the main font used in the text.
// If some character needs to have a different font, it will only have an object describing how this font
// differs from the main font used in the document.
// This way we will save huge amounts of memory.
// And this is just the point of the flyweight design pattern.
// The flyweight design pattern minimizes the memory usage of an application by sharing as much data as
// possible between multiple similar objects.
// So as you see, string interning uses this pattern. Instead of having multiple identical strings
// we have only one in memory and it is referenced by each variable or field that would store this exact
// value.