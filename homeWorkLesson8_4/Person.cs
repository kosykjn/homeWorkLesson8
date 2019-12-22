namespace homeWorkLesson8_4
{
    class Person
    {
        public int BirthYear { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private  set; }

        public Person(int birthYear, string name, string surname)
        {
            BirthYear = birthYear;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"Имя: {Name} \nФамилия: {Surname} \nГод рождения: {BirthYear}";
        }
    }
}
