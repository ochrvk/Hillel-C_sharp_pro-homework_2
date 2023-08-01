namespace Task_2
{
    public class Ukulele : MusicInstrument
    {
        public Ukulele()
        {
            Name = "Ukulele";

            Description = "The ukulele YOO-kə-LAY-lee; from Hawaiian: ʻukulele, " +
                "approximately OO-koo-LEH-leh), also called a uke, " +
                "is a member of the lute family of instruments of Portuguese origin and popularized " +
                "in Hawaii. It generally employs four nylon strings.\r\n" +
                "The tone and volume of the instrument vary with size and construction. " +
                "Ukuleles commonly come in four sizes: soprano, concert, tenor, and baritone.";


            InstrumentHistory = "Developed in the 1880s, the ukulele is based on several small, " +
                "guitar-like instruments of Portuguese origin, the machete, cavaquinho, timple, " +
                "and rajão, introduced to the Hawaiian Islands by Portuguese immigrants from Madeira, " +
                "the Azores and Cape Verde. Three immigrants in particular, " +
                "Madeiran cabinet makers Manuel Nunes, José do Espírito Santo, and Augusto Dias, " +
                "are generally credited as the first ukulele makers. " +
                "Two weeks after they disembarked from the SS Ravenscrag in late August 1879, " +
                "the Hawaiian Gazette reported that \"Madeira Islanders recently arrived here, " +
                "have been delighting the people with nightly street concerts.\"";
        }

        public new void Sound()
        {
            Console.WriteLine("Ukulele sounds");
        }

    }
}
