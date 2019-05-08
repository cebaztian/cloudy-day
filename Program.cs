namespace CloudyDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var townsAmount = int.Parse(ReadConsole("Enter the number of towns [2]", "2", Validator.ValidIntValue));
            var townsPopulations = ToList(ReadConsole("Enter the population of each town [10 100]", "10 100", Validator.ValidLongValues));
            var townsLocations = ToList(ReadConsole("Enter the location of each town [5 100]", "5 100", Validator.ValidLongValues));
            var cloudsAmount = int.Parse(ReadConsole("Enter the number of clouds [1]", "1", Validator.ValidIntValue));
            var cloudsLocations = ToList(ReadConsole("Enter the location of each cloud [4]", "4", Validator.ValidLongValues));
            var cloudsRadius = ToList(ReadConsole("Enter the radius of each cloud [1]", "1", Validator.ValidLongValues));

            if (!Validator.Match(townsAmount, townsPopulations.Count))
            {
                Console.WriteLine("The population information doesn't match with towns amount, you must restart the program!");
                Console.ReadKey();
                return;
            }

            if (!Validator.Match(townsAmount, townsLocations.Count))
            {
                Console.WriteLine("The towns locations doesn't match with towns amount, you must restart the program!");
                Console.ReadKey();
                return;
            }

            if (!Validator.Match(cloudsAmount, cloudsLocations.Count))
            {
                Console.WriteLine("The towns clouds locations doesn't match with clouds amount, you must restart the program!");
                Console.ReadKey();
                return;
            }

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

        private static string ReadConsole(string message, string defaultValue, Func<string, bool> isValid)
        {
            Console.WriteLine(message);
            var result = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(result))
            {
                return defaultValue;
            }
            else if (isValid(result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid value, try again");
                return ReadConsole(message, defaultValue, isValid);
            }
        }

        private static List<int> ToList(string value)
        {
            var values = value.Split(' ').ToList();
            return values.Select(val => int.Parse(val)).ToList();
        }
    }
}
