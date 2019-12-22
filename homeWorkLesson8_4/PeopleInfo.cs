using System;

namespace homeWorkLesson8_4
{
    class PeopleInfo
    {
        private Person[] peoples;
        public Person[] Peoples
        {
            get
            {
                return peoples;
            }
            set
            {
                peoples = value;
            }
        }

        private void SortPeoples()
        {
            for (int i = 0; i < peoples.Length; i++)
            {
                for (int j = i + 1; j < peoples.Length; j++)
                {
                    if (peoples[i].BirthYear > peoples[j].BirthYear)
                    {
                        var tmp = peoples[i];
                        peoples[i] = peoples[j];
                        peoples[j] = tmp;
                    }
                }
            }
        }

        public void ShowPeoples()
        {
            //Сортируем массив людей по их году рождения
            SortPeoples();

            foreach (var people in peoples)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(new string('*', 25));
                Console.ForegroundColor = ConsoleColor.Yellow;


                Console.WriteLine(people);
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string('*', 25));
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public PeopleInfo(params Person[] inputPeoples)
        {
            Peoples = inputPeoples;
        }
    }
}
