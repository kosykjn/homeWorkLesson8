using System;

namespace homeWorkLesson8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var badPupil1 = new BadPupil("Vasya");
            var badPupil2 = new BadPupil("Petya");
            var goodPupil = new GoodPupil("Ivan");
            var excellentPupil1 = new ExcellentPupil("Jenya");
            var excellentPupil2 = new ExcellentPupil("Vlad");

            var classRoom = new ClassRoom(badPupil1, badPupil2, goodPupil, excellentPupil1, excellentPupil2);

            classRoom.ShowInfo();

            Console.ReadKey();
        }
    }
}
