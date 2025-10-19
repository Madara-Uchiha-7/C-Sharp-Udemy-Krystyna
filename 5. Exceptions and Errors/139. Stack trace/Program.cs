// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

namespace _139._Stack_trace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // When error comes, go to the quick watch
            // using the view details. Then there is one
            // option called stack strace.
            // In the bottom we have the method that is called 
            // first.
            // Then another methods may come which are being called
            // So, basically it stores the stack like structure, which shows
            // us, from bottom to end i.e. from start to end that 
            // from where the error came and what is the connection.
            // The on top comes the exception, it means the method
            // before that is the place where that error came.

            // It is better to handle the exceptions
            // because user may face issue when run appliaction.
            // For e.g., error is there and code did not reach the 
            // Console.ReadKey(); then error will come and user also will not
            // be able to share it.
        }
    }
}
