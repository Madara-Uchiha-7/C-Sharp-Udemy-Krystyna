///
/// We can think of an array as a collection of boxes holding values of the same type.
/// Each of its elements is placed at a given index.
/// This array is single-dimensional, but C# allows us to have multi-dimensional arrays too.
/// 
/// We could imagine a two-dimensional array as a matrix of values.
/// Each element is stored under not a single index but a pair of indices. In a two-dimensional array of
/// size 4 by 3 we could store 12 elements.
/// Two-dimensional arrays are very useful when in our program, we try to represent things like, for example,
/// a chessboard.
/// 
/// To imagine a three dimensional array, we would need to think of a cube, perhaps something similar
/// to a Rubik's cube .In a three dimensional array of size
/// 4 by 5 by 3
/// we could store 60 items.
/// 
/// Let's now practice using multidimensional arrays.

char[,] letters = new char[2, 3];

/// 
/// As you can see, this looks quite similar to how we declared a one-dimensional array, except for the
/// comma and two dimensions.
///
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

///
/// 
///
var letters1 = new[,]
{
    { 'A', 'B', 'C'},
    { 'D', 'E', 'F'},
};

///
/// We must put each of the array rows into a separate pair of braces.
/// We can not use .Lenght because it will give the total elements in the array.
/// Lets get the size of this 2 D array.
///
var rows = letters.GetLength(0);
var cols = letters.GetLength(1);

Console.WriteLine(rows);
Console.WriteLine(cols);