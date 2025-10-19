namespace GameDataParcer.UserInteraction
{
    // Since, we are taking the input from the Console class,
    // but this requirement can change anytime. So lets connect this class to the interface.
    // And we will use this interface for dependancy inversion.
    public interface IUserInteractor
    {
        string ReadValidFilePath();
        void PrintMessage(string message);

        void PrintError(string message);
    }
}
