namespace CloudyDay
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            PrepareConsoleToReadLargeString();

            var townsAmount = Int64.Parse(Console.ReadLine());
            var townsPopulations = ToList(Console.ReadLine());
            var townsLocations = ToList(Console.ReadLine());
            var cloudsAmount = Int64.Parse(Console.ReadLine());
            var cloudsLocations = ToList(Console.ReadLine());
            var cloudsRadius = ToList(Console.ReadLine());

            var city = new City();

            Town town;
            for (int i = 0; i < townsAmount; i++)
            {
                town = new Town(townsPopulations[i], townsLocations[i]);
                city.Towns.Add(town);
            }

            Cloud cloud;
            for (int i = 0; i < cloudsAmount; i++)
            {
                cloud = new Cloud(cloudsLocations[i], cloudsRadius[i]);
                city.Clouds.Add(cloud);
            }

            Console.Clear();
            Console.WriteLine(city.GetMaxSunnyPopulation());
        }

        private static void PrepareConsoleToReadLargeString()
        {
            byte[] inputBuffer = new byte[1024];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
        }

        private static List<Int64> ToList(string value)
        {
            var values = value.Split(' ').ToList();
            return values.Select(val => Int64.Parse(val)).ToList();
        }
    }
}
