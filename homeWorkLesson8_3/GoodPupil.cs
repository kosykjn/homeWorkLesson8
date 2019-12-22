using System;

namespace homeWorkLesson8_3
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        {
        }

        public override void Study()
        {
            Console.WriteLine("Учусь нормально!");
        }
        public override void Read()
        {
            Console.WriteLine("Читаю приемлемо!");
        }
        public override void Write()
        {
            Console.WriteLine("Пишу хорошо!");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдыхаю в меру!");
        }
    }
}
