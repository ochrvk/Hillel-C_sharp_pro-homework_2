namespace Task_2
{
    public class Trombone : MusicInstrument
    {
        public Trombone()
        {
            Name = "Trombone";

            Description = "The trombone (German: Posaune, Italian, French: trombone) " +
                "is a musical instrument in the brass family. " +
                "As with all brass instruments, " +
                "sound is produced when the player's vibrating lips cause " +
                "the air column inside the instrument to vibrate. " +
                "Nearly all trombones use a telescoping slide mechanism " +
                "to alter the pitch instead of the valves used by other brass instruments. " +
                "The valve trombone is an exception, " +
                "using three valves similar to those on a trumpet, " +
                "and the superbone has valves and a slide.";


            InstrumentHistory = "\"Trombone\" comes from the Italian word tromba (trumpet) plus" +
                " the suffix -one (big), meaning \"big trumpet\".\r\nDuring the Renaissance, " +
                "the equivalent English term was \"sackbut\". " +
                "The word first appears in court records in 1495 as \"shakbusshe\" at about " +
                "the time King Henry VII married a Portuguese princess who brought " +
                "musicians with her. \"Shakbusshe\" is similar to \"sacabuche\", " +
                "attested in Spain as early as 1478. The French equivalent \"saqueboute\" " +
                "appears in 1466.\r\nThe German \"Posaune\" long predates the invention " +
                "of the slide and could refer to a natural trumpet as late as " +
                "the early fifteenth century.";
        }

        public new void Sound()
        {
            Console.WriteLine("Trombone sounds");
        }
    }
}
