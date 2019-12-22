namespace homeWorkLesson8_1
{
    class AnimalWithTail
    {
        public string Color { get; set; }

        public int Age { get; set; }

        public Tail Tail { get; set; }

        public AnimalWithTail(int age, string color, int tailLength, string tailView)
        {
            Age = age;
            Color = color;
            Tail = new Tail(tailLength, tailView);
        }

        public AnimalWithTail(int age, string color, Tail tail)
        {
            Age = age;
            Color = color;
            Tail = tail;
        }
    }
}
