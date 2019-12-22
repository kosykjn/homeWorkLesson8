namespace homeWorkLesson8_2
{
    class Shape
    {
        public double Volume
        {
            get
            {
                return GetVolume();
            }
        }

        public virtual double GetVolume()
        {
            return 0.0;
        }
    }
}
