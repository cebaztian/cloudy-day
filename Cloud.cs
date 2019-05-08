namespace CloudyDay
{
    using System;

    public class Cloud
    {
        public int Location { get; private set; }
        public int Radius { get; private set; }
        public int Beggining
        {
            get
            {
                return Location - Radius;
            }
        }
        public int End
        {
            get
            {
                return Location + Radius;
            }
        }

        public Cloud(int location, int radius)
        {
            Location = location;
            Radius = radius;
        }
    }
}
