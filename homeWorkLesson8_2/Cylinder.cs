using System;

namespace homeWorkLesson8_2
{
    class Cylinder : Shape
    {
       public double RadiusCylinder { get; private set; }
        public double HeigthCylinder { get; private set; }

        public override double GetVolume()
        {
            return Math.PI * RadiusCylinder * RadiusCylinder * HeigthCylinder;
        }

        public Cylinder (double radiusCylinder, double heigthCylinder)
        {
            RadiusCylinder = radiusCylinder;
            HeigthCylinder = heigthCylinder;
        }
    }
}
