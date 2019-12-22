using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1993, "Vasya", "Vasyev");
            Student student2 = new Student(1990, "Ivan", "Ivanov");
            Student student3 = new Student(1991, "Denis", "Denisov");
            Student student4 = new Student(1996, "Kolya", "Baskov");
            Student student5 = new Student(1970, "Ilya", "Lozhov");

            Teacher teacher1 = new Teacher(1950, "Petya" , "Zhukov");
            Teacher teacher2 = new Teacher(1930, "Nikolya", "Buran");

            PeopleInfo peopleContainer = new PeopleInfo(
                student1,
                student2,
                student3,
                student4,
                student5,
                teacher1,
                teacher2);

            peopleContainer.ShowPeoples();

            Console.ReadKey();
        }
    }
}
