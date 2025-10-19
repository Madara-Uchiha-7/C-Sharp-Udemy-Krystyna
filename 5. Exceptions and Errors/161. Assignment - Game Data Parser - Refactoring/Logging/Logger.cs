namespace GameDataParcer.Logging
{
    public class Logger
    {
        private readonly string _logFileName;

        public Logger(string logFileName)
        {
            _logFileName = logFileName;
        }

        public void Log(Exception ex)
        {
            // We use the @ symbol here to define a multi-line string easily.
            // If we didn't use the @ symbol, this code would not work.
            var entry =
    $@"[{DateTime.Now}] 
Exception Message: {ex.Message}
Stack Trace : {ex.StackTrace}

";
            // AppendAllText : If file does not exist then it will create the file.
            // If you hover over AppendAllText, then you will know it in the description.
            // So we don't need to worry about some exception being thrown.
            File.AppendAllText(_logFileName, entry);
        }
    }
}
