namespace Task_2
{
    public class Cello : MusicInstrument
    {
        public Cello()
        {
            Name = "Cello";

            Description = "The cello, or violoncello VY-ə-lən-CHEL-oh, " +
                "is a bowed (sometimes plucked and occasionally hit) string instrument " +
                "of the violin family. Its four strings are usually tuned in perfect fifths: " +
                "from low to high, C2, G2, D3 and A3. " +
                "The viola's four strings are each an octave higher. " +
                "Music for the cello is generally written in the bass clef, with tenor clef, " +
                "and treble clef used for higher-range passages.";

            InstrumentHistory = "The violin family, including cello-sized instruments, " +
                "emerged c. 1500 as a family of instruments distinct from the viola da gamba family. " +
                "The earliest depictions of the violin family, from northern Italy c. 1530, " +
                "show three sizes of instruments, roughly corresponding to " +
                "what we now call violins, violas, and cellos. Contrary to a popular misconception, " +
                "the cello did not evolve from the viola da gamba, " +
                "but existed alongside it for about two and a half centuries. ";
        }


        public new void Sound()
        {
            Console.WriteLine("Cello sounds");
        }
    }
}
