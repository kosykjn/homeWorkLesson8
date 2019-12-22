using System;

namespace homeWorkLesson8_1
{
    class Dog : AnimalWithTail
    {
        private string Name { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Зовут {Name} возраст {Age} цвет {Color} длина хвоста {Tail.Length} и его вид {Tail.View}");
        }

        public Dog(string name, int age, string color, int tailLength, string tailView)
            : base(age, color, tailLength, tailView)
        {
            Name = name;
        }

        public Dog(string name, int age, string color, Tail tail)
           : base(age, color, tail)
        {
            Name = name;
        }
    }
}
