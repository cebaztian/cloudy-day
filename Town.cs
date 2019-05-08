
namespace CloudyDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Town
    {
        public Int64 Population { get; set; }
        public Int64 Location { get; set; }
        public bool Sunny { get; set; }

        public Town(Int64 population, Int64 location)
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
