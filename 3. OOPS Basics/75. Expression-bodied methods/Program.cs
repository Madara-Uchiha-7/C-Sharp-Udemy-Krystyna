// If your method contains only single statement or single expression
// then we can write that method in other way to make it shorter
// We can do so using => syntax
// This is only allowed for one expression or one statement
// Expression is something that evaluates to a value.
// Example : 1 + 2, GetText()
// Statement does not evaluate to a value.
// Example : If statement ,  Console.WriteLine("hi");

// We can pass the parameters to arrow method in the same way we do for normal method
/*
    public int CalculateCircumference()
    {
        return 2 * width + 2 * height;
    }
    TO:->
    public int CalculateCircumference() => 2 * width + 2 * height;
 */