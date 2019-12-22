using System;

namespace homeWorkLesson8_2
{
    class Ball : Shape
    {
        public double RadiusBall { get; private set; }

        public override double GetVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(RadiusBall, 3);
        }

        public Ball (double radiusBall)
        {
            RadiusBall = radiusBall;
        }
    }
}
