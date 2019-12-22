namespace homeWorkLesson8_2
{
    class Box 
    {
        private int currentElementCount;
        private Shape[] figures;

        public double DrawerVolume { get; private set; }

        public bool Add(Shape figure)
        {
            if (currentElementCount < figures.Length)
            {
                DrawerVolume += figure.Volume;
                figures[currentElementCount++] = figure;

                return true;
            }
            else
            {
                return false;
            }
        }
        public void Clear()
        {
            DrawerVolume = 0.0;
            currentElementCount = 0;
            figures = new Shape[figures.Length];
        }
        public Box(int elementCount)
        {
            DrawerVolume = 0.0;
            currentElementCount = 0;
            figures = new Shape[elementCount];
        }
    }
}
