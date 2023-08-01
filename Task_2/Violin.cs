namespace Task_2
{
    public class Violin : MusicInstrument
    {
        public Violin()
        {
            Name = "Violin";

            Description = "The violin, sometimes known as a fiddle, " +
                "is a wooden chordophone (string instrument) in the " +
                "violin family. Most violins have a hollow wooden body. " +
                "It is the smallest and thus highest-pitched instrument " +
                "(soprano) in the family in regular use. " +
                "The violin typically has four strings (some can have five), " +
                "usually tuned in perfect fifths with notes G3, D4, A4, E5," +
                " and is most commonly played by drawing a bow across its strings. " +
                "It can also be played by plucking the strings with the fingers (pizzicato) and, " +
                "in specialized cases, by striking the strings with the wooden side of the bow (col legno).";

            InstrumentHistory = "The earliest stringed instruments were mostly plucked " +
                "(for example, the Greek lyre). Two-stringed, bowed instruments, " +
                "played upright and strung and bowed with horsehair, may have originated " +
                "in the nomadic equestrian cultures of Central Asia, in forms closely resembling " +
                "the modern-day Mongolian Morin huur and the Kazakh Kobyz. " +
                "Similar and variant types were probably disseminated along east–west trading routes " +
                "from Asia into the Middle East, and the Byzantine Empire.";
        }


        public void Sound()
        {
            Console.WriteLine("Violin sounds");
        }

    }
}
