using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tail tail = new Tail(10, "long");
            Dog dog1 = new Dog("Sharik", 5, "Black", tail);
            Dog dog2 = new Dog("Tuzik", 3, "White", 5, "short");

            dog1.ShowInfo();
            dog2.ShowInfo();

            Console.ReadKey();
        }
    }  
}
