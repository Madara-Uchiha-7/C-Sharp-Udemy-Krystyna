namespace GameDataParcer.UserInteraction
{
    public class ConsoleUserInteractor : IUserInteractor
    {
        public string ReadValidFilePath()
        {
            bool isFilePathValid = false;
            string? fileName = default;
            do
            {
                Console.WriteLine("Enter the name of the file you want to read: ");
                fileName = Console.ReadLine();

                if (fileName is null)
                {
                    Console.WriteLine("The file name can not be null.");
                }
                else if (fileName == string.Empty)
                {
                    Console.WriteLine("The file name can not be Empty.");
                }
                else if (!File.Exists(fileName))
                {
                    Console.WriteLine("File does not found.");
                }
                else
                {
                    isFilePathValid = true;
                }

            }
            while (!isFilePathValid);

            return fileName!;
        }

        // Ctrl + d :-> Select the block/line which you want to copy and paste under selected block/line.
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void PrintError(string message)
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);

            Console.ForegroundColor = originalColor;
        }
    }
}
