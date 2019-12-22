using System;

namespace homeWorkLesson8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid pyramid = new Pyramid(3,7);
            Cylinder cylinder = new Cylinder(2, 4);
            Ball ball = new Ball(3);

            Box box = new Box(2);

            var result1 = box.Add(pyramid);
            var result2 = box.Add(cylinder);
            var result3 = box.Add(ball);

            box.Clear();

            Console.ReadKey();
        }
    }
}
