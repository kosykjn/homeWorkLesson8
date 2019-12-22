using System;

namespace homeWorkLesson8_3
{
    class ClassRoom
    {
        private int maxPupilCount = 4;
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] inputPupils)
        {
            pupils = new Pupil[maxPupilCount];

            for (int i = 0; i < inputPupils.Length; i++)
            {
                if (i < pupils.Length)
                {
                    pupils[i] = inputPupils[i];
                }
                else
                {
                    Console.WriteLine("Больше учеников не поместится!");
                    break;
                }
            }
        }

        public void ShowInfo()
        {
            foreach (Pupil pupil in pupils)
            {
                if (pupil != null)
                {
                    Console.WriteLine(new string('*', 25));
                    Console.WriteLine($"Ученик: {pupil.Name}");
                    pupil.Study();
                    pupil.Read();
                    pupil.Write();
                    pupil.Relax();
                }
            }

            Console.WriteLine(new string('*', 25));
        }
    }
}
