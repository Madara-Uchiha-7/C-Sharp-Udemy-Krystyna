// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// I have written teachers code because in mine I was repeating the foreach in each child class.
/*
Currently, the StringsProcessor, StringsTrimmingProcessor, and 
StringsUppercaseProcessor classes are not implemented.
Let's understand what happens in the ProcessAll method. 
It takes a List of strings as a parameter. Inside, it has a collection of StringsProcessor objects. 
Those objects expose a Process method, which also takes a List of strings and returns the same type.

The StringsTrimmingProcessor class has a method that takes a collection of strings and, 
as a result, returns an identical collection, but with each word trimmed by half. 
So, for example, for the following input:
"bobcat", "wolverine", "grizzly"

It shall return:
"bob", "wolv", gri"
To cut a string in half, you can use the Substring method.

The StringsUppercaseProcessor class has a method that takes a collection of strings and, 
as a result, returns an identical collection, but with each word made uppercase. 
So, for example, for the following input:
"bobcat", "wolverine", "grizzly"

It shall return:
"BOBCAT", "WOLVERINE", "GRIZZLY"

Because both those transformations will be applied to the collection of strings in the ProcessAll method, 
it should return the collection like the input collection, but with each word both trimmed and made uppercase.

For example, for the following input:
"bobcat", "wolverine", "grizzly"

The result of the ProcessAll method should be:
"BOB", "WOLV", "GRI"

Your job is to create the implementations of the following classes:
StringsProcessor (base)
StringsUppercaseProcessor (derived)
StringsTrimmingProcessor (derived)
Try to avoid code duplication as much as possible.
 */
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            // stringsProcessors may hold StringsTrimmingProcessor and  StringsUppercaseProcessor
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

            List<string> result = words;

            // stringsProcessor will have StringsTrimmingProcessor at 1st and then StringsUppercaseProcessor
            foreach (var stringsProcessor in stringsProcessors)
            {
                // The result is passed to the StringsTrimmingProcessor's Process and
                // then StringsUppercaseProcessor's Process. But since both of
                // these children does not have the Process, they will use the parent Process Method 
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }

    //your code goes here
    public class StringsProcessor
    {
        public List<string> Process(List<string> words)
        {
            // Once the child class List of wrods comes here
            // It will know that it has ProcessSingle() method overried. 
            // So, Perticaulr child's methods will get called and that logic will be used.
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                result.Add(ProcessSingle(word));
            }
            return result;
        }
        public virtual string ProcessSingle(string input) => input;
    }

    public class StringsTrimmingProcessor : StringsProcessor
    {
        public override string ProcessSingle(string input) => input.Substring(0, input.Length / 2);
    }
    public class StringsUppercaseProcessor : StringsProcessor
    {
        public override string ProcessSingle(string input) => input.ToUpper();
    }
}
