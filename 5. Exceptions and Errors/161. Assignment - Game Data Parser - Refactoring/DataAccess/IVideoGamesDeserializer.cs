using GameDataParcer.Model;

namespace GameDataParcer.DataAcccess
{
    public interface IVideoGamesDeserializer
    {
        List<VideoGame> DeserializeFrom(string fileName, string fileContents);
    }
}
