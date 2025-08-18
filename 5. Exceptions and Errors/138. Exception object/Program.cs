// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

namespace _138._Exception_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // There are 3 main types of erros
            // 1. Compilation error
            // 2. Runtime error : E.g. divide by 0
            // 3. Logical error : Program does not crash but also does not work.

            // In C# the runtime errors are called as Exceptions.

            // Lets see one runtime error
            /* 
             * string input = "Hi";
             * int number = int.Parse(input);
             * Console.ReadKey();
             * This string to int is not possible and will cause an error.
             * Since using of variable number is risky for next code, C# stops the 
             * code. 
             * Exceptions are also objects.
             * They can also be container for the data.
             * All exceptions are derived from System.Exception base class.
             * For e.g. in above casting example, the exception we will get is
             * System.FormatException which is the child of System.Exception.
             * There are many such types of exceptions.
             * We can also create our own exceptions by creating class which will
             * derive the System.Exception
             * If you click on view details on given Exception by C#, it will open the
             * quick watch window.
             * Once the quick watch window opens, you will see many options there.
             * Message: This property has the most information.
             * InnerException: Sometimes stores another exception object which is 
             *                 nested in main exception.
             * StackTrace: look in the next lecture.
             */
        }
    }
}
  