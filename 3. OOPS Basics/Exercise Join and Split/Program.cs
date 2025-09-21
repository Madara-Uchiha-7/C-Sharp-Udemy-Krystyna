/*
Implement the TransformSeparators method. 
Its purpose is to take a string with some separators and 
replace them with the target separators.
For example, for:
input equal to "this,is,some,string"
originalSeparator equal to ","
targetSeparator equal to "+"
The result should be "this+is+some+string"
*/
public static class StringsTransformator
{
    public static string TransformSeparators
    (
        string input,
        string originalSeparator,
        string targetSeparator
    )
    {
        return string.Join($"{targetSeparator}", (input.Split($"{originalSeparator}")));
    }
}