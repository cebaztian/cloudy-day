
namespace CloudyDay
{
    using System.Collections.Generic;
    using System.Linq;
    public class Town
    {
        public int Population { get; set; }
        public int Location { get; set; }
        public bool Sunny { get; set; }

        public Town(int population, int location)
        {
            Population = population;
            Location = location;
        }

        public bool isCloudy(List<Cloud> clouds)
        {
            return clouds.Any(cloud => Location >= cloud.Beggining && Location <= cloud.End);
        }
    }
}
