namespace homeWorkLesson8_2
{
    class Pyramid : Shape
    {
        public double PyramidBaseArea { get; private set; }
        public double PyramidHeight { get; private set; }

        public override double GetVolume()
        {
            return PyramidBaseArea * PyramidHeight;
        }

        public Pyramid (double pyramidBaseArea, double pyramidHeight)
        {
            PyramidBaseArea = pyramidBaseArea;
            PyramidHeight = pyramidHeight;
        }
    }
}
