using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                Console.WriteLine("running promotion");
                break;

                default:
                Console.WriteLine("dont know the season");
                break;
            }
        }
    }
}