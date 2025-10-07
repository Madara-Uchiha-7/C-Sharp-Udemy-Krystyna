/*
Lists - GetOnlyUpperCaseWords
Implement the GetOnlyUpperCaseWords method, which given a collection of strings, 
returns a List with only those strings which contain only uppercase letters.

The result collection should not contain duplicates.



For example:

for input List {"one", "TWO", "THREE", "four"} the result shall be {"TWO", "THREE"}

for input List {"one", "TWO", "THREE", "four", "TWO"} the result shall be {"TWO", "THREE"} 
(the second "TWO" is ignored)

for input List {"one", "TWO123", "THREE!&^", "four"} the result shall be an empty List because 
no word in this collection is built from only uppercase letters (digits and special characters 
are not letters at all). 


Please notice that digits and special characters are not letters at all, 
so words containing them should not be considered uppercase words. 
Luckily, the char.IsUpper method covers that; it returns false for any non-letter characters.



*/


public List<string> GetOnlyUpperCaseWords(List<string> words)
{
    //your code goes here
    List<string> result = new List<string>();
    foreach (var word in words)
    {
        bool isLetter = true;
        if (word.ToUpper() == word)
        {
            if (!result.Contains(word) && word.All(letter => char.IsUpper(letter)))
            {
                result.Add(word);
            }
        }
    }
    return result;
}