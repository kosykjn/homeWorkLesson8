
namespace homeWorkLesson8_4
{
    class Teacher : Person
    {
        private Student[] students;
        public Student[] Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }

        public Teacher(int birthYear, string name, string surname) 
            : base(birthYear, name, surname)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} \nТип: Учитель";
        }
    }
}
