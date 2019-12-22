namespace homeWorkLesson8_3
{
    class Pupil
    {
        public string Name { get; private set; }

        public Pupil(string name)
        {
            Name = name;
        }

        public virtual void Study()
        {

        }
        public virtual void Read()
        {

        }
        public virtual void Write()
        {

        }
        public virtual void Relax()
        {

        }
    }
}
