using System;

namespace homeWorkLesson8_3
{
    class ExcellentPupil : Pupil
    {
        public ExcellentPupil(string name) : base(name)
        {
        }

        public override void Study()
        {
            Console.WriteLine("Учусь замечательно!");
        }
        public override void Read()
        {
            Console.WriteLine("Читаю отлично!");
        }
        public override void Write()
        {
            Console.WriteLine("Пишу превосходно!");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдыхаю мало!");
        }
    }
}
