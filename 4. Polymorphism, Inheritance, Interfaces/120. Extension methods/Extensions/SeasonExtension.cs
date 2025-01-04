namespace Polymorphic.Extensions
{
    public static class SeasonExtension
    {
        // I think since this folder is inside project
        // and in project we have defined Season enum, 
        // So, I think it automatically understand when we write Season here. 
        public static Season Next(this Season season)
        {
            int seasonAsInt = (int) season;
            int nextSeason = (seasonAsInt + 1) % 4;
            return (Season)nextSeason;
        }
    }
}
