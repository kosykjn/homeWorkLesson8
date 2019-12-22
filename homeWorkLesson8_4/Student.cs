using System;

namespace homeWorkLesson8_4
{
    class Student : Person
    {
        private int maxStudyCoursesCount = 3;
        private string[] studyCourses;
        public string[] StudyCourses
        {
            get
            {
                return studyCourses;
            }
            set
            {
                studyCourses = new string[maxStudyCoursesCount];

                for (int i = 0; i < value.Length; i++)
                {
                    if (i < value.Length)
                    {
                        studyCourses[i] = value[i];
                    }
                }
            }
        }
        public void DisplayStudyCourses()
        {
            foreach (var studyCourse in studyCourses)
            {
                Console.WriteLine(studyCourse);
            }
        }
        public Student(int birthYear, string name, string surname)
            : base(birthYear, name, surname)
        {
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nТип: Студент";
        }
    }
}
