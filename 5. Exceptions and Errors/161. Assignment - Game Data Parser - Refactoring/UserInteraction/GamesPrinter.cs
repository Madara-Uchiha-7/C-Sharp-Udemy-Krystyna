using GameDataParcer.Model;

namespace GameDataParcer.UserInteraction
{
    public class GamesPrinter : IGamesPrinter
    {

        private readonly IUserInteractor _userInteractor;

        public GamesPrinter(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        // We can not make a method static if we are using any other concrete class(non static)/ interface
        // object in it.
        public void Print(List<VideoGame> videoGames)
        {
            if (videoGames.Count > 0)
            {
                _userInteractor.PrintMessage(Environment.NewLine + "Loded games are: ");
                foreach (var videoGame in videoGames)
                {
                    _userInteractor.PrintMessage(videoGame.ToString());
                }
            }
            else
            {
                _userInteractor.PrintMessage("No games are present in the input file.");
            }
        }

    }
}
