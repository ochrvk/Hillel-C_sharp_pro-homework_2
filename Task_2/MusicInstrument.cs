namespace Task_2
{
    public class MusicInstrument
    {
        public MusicInstrument()
        {
            Name = "Noisemaker";
            Description = "Musical Instrument. Nothing special.";
            InstrumentHistory = "No one remembers when it was invented.";
        }

        protected string Name { get; init; }

        protected string Description { get; init; }

        protected string InstrumentHistory { get; init; }

        public void Sound()
        {
            Console.WriteLine("Making some noise");
        }

        public void Show()
        {
            Console.WriteLine("This is " + Name);
        }

        public void Desc()
        {
            Console.WriteLine(Description);
        }

        public void History()
        {
            Console.WriteLine(InstrumentHistory);
        }
    }
}
