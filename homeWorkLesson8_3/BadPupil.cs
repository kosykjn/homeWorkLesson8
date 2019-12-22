using System;

namespace homeWorkLesson8_3
{
    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        {
        }

        public override void Study()
        {
            Console.WriteLine("Учусь плохо!");
        }
        public override void Read()
        {
            Console.WriteLine("Читаю плохо!");
        }
        public override void Write()
        {
            Console.WriteLine("Пишу ужасно!");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдыхаю много!");
        }
    }
}
