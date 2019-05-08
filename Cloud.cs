namespace CloudyDay
{
    using System;

    public class Cloud
    {
        public Int64 Location { get; private set; }
        public Int64 Radius { get; private set; }
        public Int64 Beggining
        {
            get
            {
                return Location - Radius;
            }
        }
        public Int64 End
        {
            get
            {
                return Location + Radius;
            }
        }

        public Cloud(Int64 location, Int64 radius)
        {
            Location = location;
            Radius = radius;
        }
    }
}
