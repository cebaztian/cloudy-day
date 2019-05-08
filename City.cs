using System.Linq;
using System;
using System.Collections.Generic;

namespace CloudyDay
{
    public class City
    {

        public List<Town> Towns { get; set; }
        public List<Cloud> Clouds { get; set; }

        public City()
        {
            Towns = new List<Town>();
            Clouds = new List<Cloud>();
        }

        public int GetMaxSunnyPopulation()
        {
            var targetClouds = Clouds;
            return targetClouds.Select(cloud => GetSunnyPopulation(cloud))
                               .Max();
        }

        private int GetSunnyPopulation(Cloud withoutCloud)
        {
            var targetClouds = Clouds.Except(new List<Cloud> { withoutCloud }).ToList();
            return Towns.Where(town => !town.isCloudy(targetClouds))
                        .Select(town => town.Population)
                        .Sum();

        }

    }
}
